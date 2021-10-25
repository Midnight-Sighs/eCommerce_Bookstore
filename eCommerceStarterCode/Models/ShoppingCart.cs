using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        
        public int Quanity { get; set; }

        //Foreign Key to User Table
        [ForeignKey("UserID")]

        public string UserID { get; set; }

        public User User { get; set; }

        //Foreign Key to Book Table
        [ForeignKey("BookId")]

        public int BookID { get; set; }

        public Book Book { get; set; }
    }
}
