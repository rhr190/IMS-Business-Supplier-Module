using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class InventoryManager : IdentityUser
    {
        [Key]
        public int ManagerId { get; set; }
        public string? Name { get; set; }

        public string CompanyName { get; set; }
        public string UserName { get; set; }

        public string Password {  get; set; }
    }
}
