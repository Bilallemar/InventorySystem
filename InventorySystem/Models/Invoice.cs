namespace InventorySystem.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public String? Description { get; set; }
        public int Status { get; set; }

    }
}
