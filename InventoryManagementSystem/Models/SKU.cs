using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class SKU
    {
        [Key]
        public int SKUId { get; set; }
        public int SupplierId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProductQuantity { get; set; }

        public int TotalCost { get; set; }


    }
}
