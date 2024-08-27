using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Entities
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SKU> SKUs { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<SuppliedSKUs> SuppliedSKUs { get; set; }

        public DbSet<RequestSKUs> RequestSKUs { get; set; }

        public DbSet<ProductSupplier> Suppliers { get; set; }
        public DbSet<InventoryManager> Managers { get; set; }



    }
 
}
