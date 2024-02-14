using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class Invoice_Detail
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public double? SellingQty { get; set; }
        public double? UnitPrice { get; set; }
        public double? SellingPrice { get; set; }
        public int? Status { get; set; }

    }
}
