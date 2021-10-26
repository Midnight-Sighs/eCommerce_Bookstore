using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class BookMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "568b4976-27fa-48d5-b6b9-d93fe9b04574");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eed4b5a-e3da-4ea9-aa46-dc02fa107068");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16769c5f-e780-4c20-adfb-83d50411c1d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f575fc6-4556-4661-a73c-2518baa026cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "951b426b-b7c2-472e-aea2-b0d0dc5eb72e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9c31535-f160-49ef-acb8-4bc679886c18");

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Book_UserId",
                table: "Book",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "568b4976-27fa-48d5-b6b9-d93fe9b04574", "ef64a94f-58ca-489e-a70d-1a10a4c0c58b", "User", "USER" },
                    { "9eed4b5a-e3da-4ea9-aa46-dc02fa107068", "85d2a5cc-95a3-4135-99dd-706020364bfa", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { "d9c31535-f160-49ef-acb8-4bc679886c18", 0, "Some City", "62da0791-0168-4a6f-a785-b018b4c4ae52", "ChewieYou@aol.com", false, "Chewbaca", "Solo", false, null, null, null, null, null, false, "fd304ca9-d3b9-4b9f-938d-e246423d2059", "No States Here", "123 Millenium Falcon", false, "Chewie", "12345" },
                    { "1f575fc6-4556-4661-a73c-2518baa026cf", 0, "Some City", "2b2e9d10-40f0-4bb6-8ca3-42aefc753e34", "IKnow@aol.com", false, "Han", "Solo", false, null, null, null, null, null, false, "a9c48ab3-b455-4f82-bf17-51868cf2a8cc", "No States Here", "123 Millenium Falcon", false, "Han", "12345" },
                    { "16769c5f-e780-4c20-adfb-83d50411c1d8", 0, "Roach Motel", "93417918-2eb8-4650-9781-46c4a6cde3dd", "SkippySucks@aol.com", false, "Joe", "Bishop", false, null, null, null, null, null, false, "ef6e2977-499d-40ca-ae32-8e37584263aa", "Galaxy Far Away", "123 Valkyrie", false, "BishopRocks", "12345" },
                    { "951b426b-b7c2-472e-aea2-b0d0dc5eb72e", 0, "Roach Motel", "38c159c0-0c74-4369-9d77-c126b4d5ec1b", "NoDirtyMonkeys@aol.com", false, "Skippy", "The Magnificent", false, null, null, null, null, null, false, "b6b5f45b-cfb0-456c-896d-7c4e5c890156", "Galaxy Far Away", "123 Valkyrie", false, "Skippy_The_Mag", "12345" }
                });
        }
    }
}
