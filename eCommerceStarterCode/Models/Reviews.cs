using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//test
namespace eCommerceStarterCode.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }

        //FK to Books table
        [ForeignKey("BookID")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        //FK to Users Table
        [ForeignKey("UserId")] 
        public string UserId { get; set; }
        public User User { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }
    }
}