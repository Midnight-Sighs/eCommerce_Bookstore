using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        public DbSet<User> User { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<ShoppingCart> ShoppingCart {get; set;}
        public DbSet<Reviews> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            
            
            modelBuilder.Entity<User>().HasData(
                new User { Id="a", FirstName = "Chewbaca", LastName = "Solo", UserName = "Chewie", Email = "ChewieYou@aol.com", StreetAddress = "123 Millenium Falcon", City = "Some City", State = "No States Here", ZipCode = "12345"},
                new User { Id="b", FirstName = "Han", LastName = "Solo", UserName = "Han", Email = "IKnow@aol.com", StreetAddress = "123 Millenium Falcon", City = "Some City", State = "No States Here", ZipCode = "12345" },
                new User { Id="c", FirstName = "Joe", LastName = "Bishop", UserName = "BishopRocks", Email = "SkippySucks@aol.com", StreetAddress = "123 Valkyrie", City = "Roach Motel", State = "Galaxy Far Away", ZipCode = "12345" },
                new User { Id="d", FirstName = "Skippy", LastName = "The Magnificent", UserName = "Skippy_The_Mag", Email = "NoDirtyMonkeys@aol.com", StreetAddress = "123 Valkyrie", City = "Roach Motel", State = "Galaxy Far Away", ZipCode = "12345" }
                );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId=-1, Title = "Expeditionary Force: Columbus Day", Author = "Craig Alanson", Description = "We were fighting on the wrong side, of a war we couldn't win. And that was the good news. The Ruhar hit us on Columbus Day.There we were, innocently drifting along the cosmos on our little blue marble, like the native Americans in 1492.Over the horizon come ships of a technologically advanced, aggressive culture, and BAM! There go the good old days, when humans only got killed by each other.So,Columbus Day.It fits.", Genre = "Military Sci-fi", ReleaseYear = "2016", Price = 9.99, ISBN = "9781520126241" },
                new Book { BookId=-2,Title = "In the Name of the Wind", Author = "Patrick Rothfuss", Description = "The Name of the Wind is an epic fantasy by Patrick Rothfuss in which the legendary hero Kvothe, now in hiding as Waystone Inn owner Kote, recounts his past experiences to Chronicler, a story collector. The book forms the first of the three parts of Rothfuss's Kingkiller Chronicle.", Genre = "Fantasy", ReleaseYear = "2007", ISBN = "9780756404741", Price = 8.99 },
                new Book { BookId=-3, Title = "Hounded", Author = "Kevin Hearne", Description= "The first novel in the New York Times bestselling Iron Druid Chronicles—the hilarious, action-packed tales of a two-thousand-year-old Druid pursued by ancient gods in the modern world", Genre="Fantasy", Price=11.99, ReleaseYear="2011", ISBN= "9780356501192" },
                new Book { BookId=-4,Title = "A Scanner Darkly", Author="Phillip K Dick", Description="An addict and an undercover officer battle drug addiction in an alternate historical United States.", Genre="Fiction", ReleaseYear="1977", Price=7.99, ISBN= "9780345260642" },
                new Book { BookId=-5,Title = "Dune", Author= "Frank Herbert", ReleaseYear="1965", Description= "Dune is set in the distant future amidst a feudal interstellar society in which various noble houses control planetary fiefs. It tells the story of young Paul Atreides, whose family accepts the stewardship of the planet Arrakis. While the planet is an inhospitable and sparsely populated desert wasteland, it is the only source of melange, or \"spice\", a drug that extends life and enhances mental abilities. Melange is also necessary for space navigation, which requires a kind of multidimensional awareness and foresight that only the drug provides", Price=14.99, ISBN= "9780441172719", Genre="Sci-Fi"}
                ) ;

            modelBuilder.Entity<Reviews>().HasData(
                new Reviews { ReviewId=-1, BookId = -1, UserId="c", Review = "Ten outta ten!  It starts slow, but wait until you meet the star of the show before you make your judgement!", Rating = 5 },
                new Reviews { ReviewId=-2,BookId = -5,  UserId="b", Review = "UUUhhhh.......not what I was expecting", Rating = 3 },
                new Reviews { ReviewId=-3, BookId = -2,  UserId="a", Review = "LOVE IT!", Rating = 5}
                ); ;

            modelBuilder.Entity<ShoppingCart>().HasData(
                new ShoppingCart { UserId="c", CartId=-1, BookId = -1, Quantity = 1 },
                new ShoppingCart { UserId ="a", CartId=-2, BookId = -2, Quantity = 2 }
                );
        }

      



    }
}
