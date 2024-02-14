using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class Customar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? CustomarImage { get; set; }
        public string? MobileNo { get; set; }
        public string? Email { get; set;}
        public string? Address { get; set; }
        [Required]
        public int Status { get; set; }

    }
}
