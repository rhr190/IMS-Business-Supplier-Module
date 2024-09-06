using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class InventoryManager : AppUser
    {
        public List<RequestSKUs>? RequestSKUs { get; set; }

    }
}
