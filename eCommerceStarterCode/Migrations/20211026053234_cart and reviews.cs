using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class cartandreviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9469de53-5f00-4c6c-bbd5-887e7f1ec01d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9966cc4-8442-4db3-94ae-0034e725dd3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8af669c2-07b0-4db4-8323-126fb38ecfb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b454ca8e-3b1e-4839-b2bf-56e291605934");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2ee5751-fc82-44bc-8e41-74065489cd0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7116811-f9a5-47f0-b77f-fc5127930d44");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Book",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "39561f7f-9433-497a-835b-c87606492129", "d1585c9a-bc83-4c75-b013-c8c7b9ed7e58", "User", "USER" },
                    { "ba4e5e79-8a3f-4abc-b5e2-9130c44b8ea2", "afe1ba1e-219a-495d-8593-0b7b3c29e117", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { "f683661e-4215-435a-b0c6-1426bca2644b", 0, "Some City", "14285598-8bdb-4f95-aa6d-c2da2fc9198a", "ChewieYou@aol.com", false, "Chewbaca", "Solo", false, null, null, null, null, null, false, "0a9b62f6-3a42-409f-afc7-5988ac770e2a", "No States Here", "123 Millenium Falcon", false, "Chewie", "12345" },
                    { "bc89c48d-c6d4-4719-b295-dd22aa64a4db", 0, "Some City", "f83dd3f3-44ff-4076-97a7-f5928c40ae51", "IKnow@aol.com", false, "Han", "Solo", false, null, null, null, null, null, false, "3e52b266-315a-40bf-ba38-734fcfea021b", "No States Here", "123 Millenium Falcon", false, "Han", "12345" },
                    { "9c793c4d-94ef-40b5-97af-1767a5792eed", 0, "Roach Motel", "98155998-d415-471f-84d8-ed26e67dabcb", "SkippySucks@aol.com", false, "Joe", "Bishop", false, null, null, null, null, null, false, "b95e89a4-9816-416b-97d3-d23b3dbf9f85", "Galaxy Far Away", "123 Valkyrie", false, "BishopRocks", "12345" },
                    { "5709fb0f-12eb-4142-864a-30dac6098ead", 0, "Roach Motel", "1bd58ef5-6a07-4491-b038-cca8c21b000e", "NoDirtyMonkeys@aol.com", false, "Skippy", "The Magnificent", false, null, null, null, null, null, false, "6b88f957-57a6-4fb8-9a93-6ebe9fd1d228", "Galaxy Far Away", "123 Valkyrie", false, "Skippy_The_Mag", "12345" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "Description", "Genre", "ISBN", "Price", "ReleaseYear", "Title", "UserId" },
                values: new object[,]
                {
                    { -1, "Craig Alanson", "We were fighting on the wrong side, of a war we couldn't win. And that was the good news. The Ruhar hit us on Columbus Day.There we were, innocently drifting along the cosmos on our little blue marble, like the native Americans in 1492.Over the horizon come ships of a technologically advanced, aggressive culture, and BAM! There go the good old days, when humans only got killed by each other.So,Columbus Day.It fits.", "Military Sci-fi", "9781520126241", 9.9900000000000002, "2016", "Expeditionary Force: Columbus Day", null },
                    { -2, "Patrick Rothfuss", "The Name of the Wind is an epic fantasy by Patrick Rothfuss in which the legendary hero Kvothe, now in hiding as Waystone Inn owner Kote, recounts his past experiences to Chronicler, a story collector. The book forms the first of the three parts of Rothfuss's Kingkiller Chronicle.", "Fantasy", "9780756404741", 8.9900000000000002, "2007", "In the Name of the Wind", null },
                    { -3, "Kevin Hearne", "The first novel in the New York Times bestselling Iron Druid Chronicles—the hilarious, action-packed tales of a two-thousand-year-old Druid pursued by ancient gods in the modern world", "Fantasy", "9780356501192", 11.99, "2011", "Hounded", null },
                    { -4, "Phillip K Dick", "An addict and an undercover officer battle drug addiction in an alternate historical United States.", "Fiction", "9780345260642", 7.9900000000000002, "1977", "A Scanner Darkly", null },
                    { -5, "Frank Herbert", "Dune is set in the distant future amidst a feudal interstellar society in which various noble houses control planetary fiefs. It tells the story of young Paul Atreides, whose family accepts the stewardship of the planet Arrakis. While the planet is an inhospitable and sparsely populated desert wasteland, it is the only source of melange, or \"spice\", a drug that extends life and enhances mental abilities. Melange is also necessary for space navigation, which requires a kind of multidimensional awareness and foresight that only the drug provides", "Sci-Fi", "9780441172719", 14.99, "1965", "Dune", null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "BookId", "Rating", "Review", "UserId", "UserId1" },
                values: new object[,]
                {
                    { -1, -1, 5, "Ten outta ten!  It starts slow, but wait until you meet the star of the show before you make your judgement!", 3, null },
                    { -3, -2, 5, "LOVE IT!", 1, null },
                    { -2, -5, 3, "UUUhhhh.......not what I was expecting", 2, null }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "CartId", "BookId", "Quantity", "UserId", "UserId1" },
                values: new object[,]
                {
                    { -1, -1, 1, 4, null },
                    { -2, -2, 2, 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId1",
                table: "Reviews",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_BookId",
                table: "ShoppingCart",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_UserId1",
                table: "ShoppingCart",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39561f7f-9433-497a-835b-c87606492129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba4e5e79-8a3f-4abc-b5e2-9130c44b8ea2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5709fb0f-12eb-4142-864a-30dac6098ead");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c793c4d-94ef-40b5-97af-1767a5792eed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc89c48d-c6d4-4719-b295-dd22aa64a4db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f683661e-4215-435a-b0c6-1426bca2644b");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: -1);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9469de53-5f00-4c6c-bbd5-887e7f1ec01d", "f52b4edf-2e34-40d9-a003-8c7cda746e84", "User", "USER" },
                    { "c9966cc4-8442-4db3-94ae-0034e725dd3c", "821ee7f1-b804-4529-b8f5-c409628d47bd", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { "e7116811-f9a5-47f0-b77f-fc5127930d44", 0, "Some City", "21f474e6-62a4-4227-8bce-9f70843c18fa", "ChewieYou@aol.com", false, "Chewbaca", "Solo", false, null, null, null, null, null, false, "4007b457-13fc-40a7-8fd9-f31951aed11c", "No States Here", "123 Millenium Falcon", false, "Chewie", "12345" },
                    { "b454ca8e-3b1e-4839-b2bf-56e291605934", 0, "Some City", "da7590a4-a374-4325-bf60-58d60bf5f7ee", "IKnow@aol.com", false, "Han", "Solo", false, null, null, null, null, null, false, "5c1e6802-03b2-4748-850f-09e5490022b2", "No States Here", "123 Millenium Falcon", false, "Han", "12345" },
                    { "d2ee5751-fc82-44bc-8e41-74065489cd0e", 0, "Roach Motel", "5f76e197-adc9-4cea-aa42-ac3a1047f297", "SkippySucks@aol.com", false, "Joe", "Bishop", false, null, null, null, null, null, false, "d22771d2-37a6-4a01-9074-569da1de0388", "Galaxy Far Away", "123 Valkyrie", false, "BishopRocks", "12345" },
                    { "8af669c2-07b0-4db4-8323-126fb38ecfb6", 0, "Roach Motel", "60bd1a20-4aa3-485b-90cb-817f4c4aa34c", "NoDirtyMonkeys@aol.com", false, "Skippy", "The Magnificent", false, null, null, null, null, null, false, "f5e0bc52-73f1-4da9-8e98-57b2331b3692", "Galaxy Far Away", "123 Valkyrie", false, "Skippy_The_Mag", "12345" }
                });
        }
    }
}
