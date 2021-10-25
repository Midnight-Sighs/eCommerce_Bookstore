using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public partial class Book
    {
        public Book()
        {
            Users = new HashSet<User>();
        }

        public int BookId { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }

        public string ReleaseYear { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
