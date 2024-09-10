using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class SupplierController : Controller
    {
        [Authorize]
        public IActionResult Index(NewUserDto model)
        {
            return View(model);
        }
    }
}
