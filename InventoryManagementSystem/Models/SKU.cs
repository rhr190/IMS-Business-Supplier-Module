using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class SKU
    {
        [Key]
        public int SKUId { get; set; }
        public int SupplierId { get; set; }

        public int ProductId { get; set; }

        public int ProductQuantity { get; set; }

        public int SKUQuantity { get; set; }

        public int TotalCost { get; set; }


    }
}
