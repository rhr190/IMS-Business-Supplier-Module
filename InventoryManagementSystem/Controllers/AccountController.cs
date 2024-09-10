using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace InventoryManagementSystem.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        private const string _baseUrl = "https://localhost:7181/";
        private const string _supplierController = "supplier";
        private const string _managerController = "controller";

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }
        private void setJWTCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddMinutes(2),
            };
            Response.Cookies.Append("jwtCookie", token, cookieOptions);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(!ModelState.IsValid || model.Role != "Manager" && model.Role != "Supplier") return View(model);
            var roleExists = await _roleManager.RoleExistsAsync(model.Role);
            if (roleExists && model.Role == "Manager") 
            {
                var user = new InventoryManager { FullName = model.FullName, UserName = model.UserName, CompanyName = model.CompanyName, Address = model.Address, Email = model.Email, PhoneNumber = model.PhoneNumber, Role = model.Role };
                var result = await _userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, model.Role);
                    return RedirectToAction("Index", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }
            if(roleExists && model.Role == "Supplier")
            {
                var user = new ProductSupplier { FullName = model.FullName, UserName = model.UserName, CompanyName = model.CompanyName, Address = model.Address, Email = model.Email, PhoneNumber = model.PhoneNumber, Role = model.Role };
                var result = await _userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, model.Role);
                    return RedirectToAction("Privacy", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }
            
            return View(model);
        }

        [HttpGet]
        public IActionResult LoginHelper()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginHelper(LoginViewModel model) 
        {
            if(!ModelState.IsValid) return View(model);
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == model.Username.ToLower());
            if(user == null) return View(model);
            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            if (!result.Succeeded) return View(model);
            var generatedToken = _tokenService.createToken(user);
            setJWTCookie(generatedToken);
            return RedirectToAction("Login", new NewUserDto { Username = model.Username ,Role = user.Role, Token = generatedToken });
        }
        [HttpGet]
        public async Task<IActionResult> Login (NewUserDto model)
        {
            if (model.Role == "Supplier")
            {
                var jwt = Request.Cookies["jwtCookie"];
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                    using (var response = await httpClient.GetAsync($"{_baseUrl}{_supplierController}"))
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return View("~/Views/Supplier/Index.cshtml", model);
                        }
                    }
                }
            }
            if (model.Role == "Manager")
            {
                var jwt = Request.Cookies["jwtCookie"];
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                    using (var response = await httpClient.GetAsync($"{_baseUrl}{_managerController}"))
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return View("~/Views/Manager/Index.cshtml");
                        }
                    }
                }
            }
            return RedirectToAction("LoginHelper", "Account");
        }
    }
}
