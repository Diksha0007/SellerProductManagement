using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingHub.Models
{
   
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Not a valid email")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email address")]
        public string EmailAddress { get; set; }
        public String Areas { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Confirm password")]
        public string ConfirmPassword { get; set; }
        public string ShopName { get; set; }

        
    }
}
