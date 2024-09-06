using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class RequestSKUs
    {
        [Key]
        public int RequestSKUId { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        
        public string ProductName { get; set; }

        public DateTime RequestDate { get; set; }

        public int Quantity { get; set; }

    }
}
