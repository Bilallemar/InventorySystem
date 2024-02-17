using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public float Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
