using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public Supplier? Supplier {  get; set; }
        [Required]
        public int UnitId { get; set; }
        public Unit? Unit { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public int? Status { get; set; }

    }
}
