using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Models
{
    public class Sale
    {
        [Key] 
        public int Id { get; set; }

    
        public int ProductID { get; set; }

        public Product? Product { get; set; }

        public int CustomerID { get; set; }

        public Account? Account { get; set; }

        public DateTime SaleDate { get; set; }

        public float Quantity { get; set; }

        public float UnitPrice { get; set; }
        public float Price { get; set; }

    }

}
