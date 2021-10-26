using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            
            
            modelBuilder.Entity<User>().HasData(
                new User { FirstName = "Chewbaca", LastName = "Solo", UserName = "Chewie", Email = "ChewieYou@aol.com", StreetAddress = "123 Millenium Falcon", City = "Some City", State = "No States Here", ZipCode = "12345"},
                new User { FirstName = "Han", LastName = "Solo", UserName = "Han", Email = "IKnow@aol.com", StreetAddress = "123 Millenium Falcon", City = "Some City", State = "No States Here", ZipCode = "12345" },
                new User { FirstName = "Joe", LastName = "Bishop", UserName = "BishopRocks", Email = "SkippySucks@aol.com", StreetAddress = "123 Valkyrie", City = "Roach Motel", State = "Galaxy Far Away", ZipCode = "12345" },
                new User { FirstName = "Skippy", LastName = "The Magnificent", UserName = "Skippy_The_Mag", Email = "NoDirtyMonkeys@aol.com", StreetAddress = "123 Valkyrie", City = "Roach Motel", State = "Galaxy Far Away", ZipCode = "12345" }
                );
            
        }

      



    }
}
