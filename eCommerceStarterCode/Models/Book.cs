using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Book
    {
        [Key]

        public int BookId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Author { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Genre { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string ReleaseYear { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ISBN { get; set; }
        [Column(TypeName = "float")]
        public double Price { get; set; }
        [NotMapped]
        public string ImagePath { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        //FK to Users table
        [ForeignKey("Id")]

        public string Id { get; set; }
    }
}
