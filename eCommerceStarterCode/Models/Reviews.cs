using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }

        //FK to Products table
        [ForeignKey("BookID")]
        public int BookId { get; set; }
        public Product Product { get; set; }

        //FK to Users Table
        [ForeignKey("UserId")] 
        public string UserId { get; set; }
        public User User { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }
    }
}