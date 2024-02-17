using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Models
{
    public class Sale
    {
        [Key] 
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int CustomerId { get; set; }
        public Account? Customer { get; set; }
        public DateTime SaleDate { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
    }
}
