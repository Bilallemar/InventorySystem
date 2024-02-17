using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        public int ProductID { get; set; }

        public Product? Product { get; set; }


        public int SupplierID { get; set; }

        public Account? Account { get; set; }

        public DateTime PurchaseDate { get; set; }

        public float Quantity { get; set; }

        public float UnitPrice { get; set; }
        public float Discount { get; set; }




    }
}
