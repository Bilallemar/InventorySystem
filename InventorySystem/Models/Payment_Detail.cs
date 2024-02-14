using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class Payment_Detail
    {
        [Key]
        public int Id { get; set; }
        
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
        public double? CurrentPaidAmount { get; set;}
        public DateTime? Date { get; set; }

    }

}
