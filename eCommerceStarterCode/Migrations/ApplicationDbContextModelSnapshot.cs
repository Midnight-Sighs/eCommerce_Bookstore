﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerceStarterCode.Data;

namespace eCommerceStarterCode.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "bf952386-047e-412d-9a27-eabbeb0abc81",
                            ConcurrencyStamp = "b101eb21-e622-400a-985c-166ee6fcf7f9",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "6b5ae278-387b-4855-986a-a483dc7d2001",
                            ConcurrencyStamp = "b8fb0c93-807f-4054-877a-b0184d489dd7",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = -1,
                            Author = "Craig Alanson",
                            Description = "We were fighting on the wrong side, of a war we couldn't win. And that was the good news. The Ruhar hit us on Columbus Day.There we were, innocently drifting along the cosmos on our little blue marble, like the native Americans in 1492.Over the horizon come ships of a technologically advanced, aggressive culture, and BAM! There go the good old days, when humans only got killed by each other.So,Columbus Day.It fits.",
                            Genre = "Military Sci-fi",
                            ISBN = "9781520126241",
                            Price = 9.9900000000000002,
                            ReleaseYear = "2016",
                            Title = "Expeditionary Force: Columbus Day"
                        },
                        new
                        {
                            BookId = -2,
                            Author = "Patrick Rothfuss",
                            Description = "The Name of the Wind is an epic fantasy by Patrick Rothfuss in which the legendary hero Kvothe, now in hiding as Waystone Inn owner Kote, recounts his past experiences to Chronicler, a story collector. The book forms the first of the three parts of Rothfuss's Kingkiller Chronicle.",
                            Genre = "Fantasy",
                            ISBN = "9780756404741",
                            Price = 8.9900000000000002,
                            ReleaseYear = "2007",
                            Title = "In the Name of the Wind"
                        },
                        new
                        {
                            BookId = -3,
                            Author = "Kevin Hearne",
                            Description = "The first novel in the New York Times bestselling Iron Druid Chronicles—the hilarious, action-packed tales of a two-thousand-year-old Druid pursued by ancient gods in the modern world",
                            Genre = "Fantasy",
                            ISBN = "9780356501192",
                            Price = 11.99,
                            ReleaseYear = "2011",
                            Title = "Hounded"
                        },
                        new
                        {
                            BookId = -4,
                            Author = "Phillip K Dick",
                            Description = "An addict and an undercover officer battle drug addiction in an alternate historical United States.",
                            Genre = "Fiction",
                            ISBN = "9780345260642",
                            Price = 7.9900000000000002,
                            ReleaseYear = "1977",
                            Title = "A Scanner Darkly"
                        },
                        new
                        {
                            BookId = -5,
                            Author = "Frank Herbert",
                            Description = "Dune is set in the distant future amidst a feudal interstellar society in which various noble houses control planetary fiefs. It tells the story of young Paul Atreides, whose family accepts the stewardship of the planet Arrakis. While the planet is an inhospitable and sparsely populated desert wasteland, it is the only source of melange, or \"spice\", a drug that extends life and enhances mental abilities. Melange is also necessary for space navigation, which requires a kind of multidimensional awareness and foresight that only the drug provides",
                            Genre = "Sci-Fi",
                            ISBN = "9780441172719",
                            Price = 14.99,
                            ReleaseYear = "1965",
                            Title = "Dune"
                        });
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Reviews", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = -1,
                            BookId = -1,
                            Rating = 5,
                            Review = "Ten outta ten!  It starts slow, but wait until you meet the star of the show before you make your judgement!",
                            UserId = "c"
                        },
                        new
                        {
                            ReviewId = -2,
                            BookId = -5,
                            Rating = 3,
                            Review = "UUUhhhh.......not what I was expecting",
                            UserId = "b"
                        },
                        new
                        {
                            ReviewId = -3,
                            BookId = -2,
                            Rating = 5,
                            Review = "LOVE IT!",
                            UserId = "a"
                        });
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.ShoppingCart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CartId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCart");

                    b.HasData(
                        new
                        {
                            CartId = -1,
                            BookId = -1,
                            Quantity = 1,
                            UserId = "c"
                        },
                        new
                        {
                            CartId = -2,
                            BookId = -2,
                            Quantity = 2,
                            UserId = "a"
                        });
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "a",
                            AccessFailedCount = 0,
                            City = "Some City",
                            ConcurrencyStamp = "4e23df93-619e-433c-b159-59b9272037d0",
                            Email = "ChewieYou@aol.com",
                            EmailConfirmed = false,
                            FirstName = "Chewbaca",
                            LastName = "Solo",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "68163c8e-957c-4cae-b9b4-8ca5f45c9054",
                            State = "No States Here",
                            StreetAddress = "123 Millenium Falcon",
                            TwoFactorEnabled = false,
                            UserName = "Chewie",
                            ZipCode = "12345"
                        },
                        new
                        {
                            Id = "b",
                            AccessFailedCount = 0,
                            City = "Some City",
                            ConcurrencyStamp = "a4147558-08cc-44ff-b3e8-346950bf67ee",
                            Email = "IKnow@aol.com",
                            EmailConfirmed = false,
                            FirstName = "Han",
                            LastName = "Solo",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d139d682-f790-46fc-9cc7-2f42f570d38e",
                            State = "No States Here",
                            StreetAddress = "123 Millenium Falcon",
                            TwoFactorEnabled = false,
                            UserName = "Han",
                            ZipCode = "12345"
                        },
                        new
                        {
                            Id = "c",
                            AccessFailedCount = 0,
                            City = "Roach Motel",
                            ConcurrencyStamp = "6539edb9-f41e-4046-9562-3b0fe73376d4",
                            Email = "SkippySucks@aol.com",
                            EmailConfirmed = false,
                            FirstName = "Joe",
                            LastName = "Bishop",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4e0463c5-b179-4ab9-a481-17a04984cc9f",
                            State = "Galaxy Far Away",
                            StreetAddress = "123 Valkyrie",
                            TwoFactorEnabled = false,
                            UserName = "BishopRocks",
                            ZipCode = "12345"
                        },
                        new
                        {
                            Id = "d",
                            AccessFailedCount = 0,
                            City = "Roach Motel",
                            ConcurrencyStamp = "2a1db4a6-74e4-4ec4-8b9e-b655f86fd38f",
                            Email = "NoDirtyMonkeys@aol.com",
                            EmailConfirmed = false,
                            FirstName = "Skippy",
                            LastName = "The Magnificent",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4960faff-5a85-44c4-b988-04c1ae16fd3a",
                            State = "Galaxy Far Away",
                            StreetAddress = "123 Valkyrie",
                            TwoFactorEnabled = false,
                            UserName = "Skippy_The_Mag",
                            ZipCode = "12345"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Book", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.Reviews", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eCommerceStarterCode.Models.ShoppingCart", b =>
                {
                    b.HasOne("eCommerceStarterCode.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceStarterCode.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Book");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
