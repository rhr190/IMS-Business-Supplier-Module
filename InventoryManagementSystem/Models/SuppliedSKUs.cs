using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class SuppliedSKUs
    {
        [Key]
        public int SuppliedSKUId { get; set; }

        public string ProductName { get; set; }

        public int SKUProductQuantity { get; set; }

        public int SKUQuantity {  get; set; }

        public DateTime RequestDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public int ProductPrice { get; set; }

        public int SKUPrice { get; set;}

        public int TotalPrice { get; set;}

    }
}
