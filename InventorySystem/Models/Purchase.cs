using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public string? PurchaseNo { get; set; }
        public string? Description { get; set; }
        public double? BuyingQty { get; set; }
        public int? Status { get; set; } 




    }
}
