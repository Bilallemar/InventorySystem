using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int SupplierId { get; set; }
        public Account? Supplier { get; set; }
        public DateTime PurchaseDate { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
    }
}
