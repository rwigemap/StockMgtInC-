using System.ComponentModel.DataAnnotations;

namespace StockManagement
{
    public class Product
    {
        [Key]
        public int ProductId {get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}