using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public abstract class AppUser : IdentityUser
    {
        
        public string FullName { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string Role {  get; set; }
        
    }
}
