using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? MobileNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int? Status { get; set; }



    }
}
