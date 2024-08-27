using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class ProductSupplier : IdentityUser
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }

        public string Address { get; set; }

        public string? MailAddress { get; set; }

        public string PhoneNumber {  get; set; }

        public string Password {  get; set; }
    }
}
