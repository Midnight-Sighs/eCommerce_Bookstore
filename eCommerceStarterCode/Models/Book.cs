using Microsoft.AspNetCore.Http;
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

        public double Price { get; set; }
        public string ImagePath { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        //FK to Users table
        [ForeignKey("Id")]

        public string Id { get; set; }


    }
}
