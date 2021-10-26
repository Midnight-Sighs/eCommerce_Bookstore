using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }

        public string ReleaseYear { get; set; }

        public string ISBN { get; set; }

        public float Price { get; set; }


        //FK to Users table
        [ForeignKey("UserID")]

        public string UserId { get; set; }

        public User User { get; set; }

    }
}
