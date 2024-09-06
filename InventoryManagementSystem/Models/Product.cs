using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public int? CategoryId { get; set; }

        public int ProductCost { get; set; }

        public int ProductPrice { get; set; }
    }
}
