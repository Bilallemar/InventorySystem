using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
        public int CustomerId { get; set; }
        public Customar? Customar { get; set; }
        public string? PaidStatus { get; set;}
        public double? PaidAmount { get; set; }
        public double? DueAmount { get; set; }
        public double? TotalAmount { get; set; }
        public double? DiscountAmount { get; set; }



    }
}
