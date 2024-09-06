using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class ProductSupplier : AppUser
    {
        public List<SuppliedSKUs>? SuppliedSKUs { get; set; }
    }
}
