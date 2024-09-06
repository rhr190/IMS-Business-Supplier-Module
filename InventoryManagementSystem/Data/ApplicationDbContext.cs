using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
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

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<InventoryManager> InventoryManagers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>().UseTptMappingStrategy();
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Supplier",
                    NormalizedName = "SUPPLIER"
                },
                new IdentityRole
                {
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }

    }
 
}
