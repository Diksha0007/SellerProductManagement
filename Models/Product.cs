using System.ComponentModel.DataAnnotations;

namespace SellerProductManagement.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set;}
        public byte[] ImagesUpload { get; set; }



    }
}
