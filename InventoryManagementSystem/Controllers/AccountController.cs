using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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
            if(!ModelState.IsValid || model.Role == null) return View(model);
            if(model.Role == "Manager") 
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
            if(model.Role == "Supplier")
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
        
        public IActionResult Login()
        {
            return View();
        }
    }
}
