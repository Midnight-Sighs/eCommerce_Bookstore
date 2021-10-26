using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class MigrateMe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8be52fe5-4f35-4d63-91ca-d9994f67b163");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a68804ff-bc45-4aaf-8421-96f96acd14dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55e04b82-d91f-4bd5-8b91-e87447413124");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a46be1d9-0ce7-44ff-920f-ed7c67d7bebb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba344a0e-b2c7-409d-a3ce-06189a38efce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d14bb7-1cbd-4ded-999c-2f684aafdc81");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8be52fe5-4f35-4d63-91ca-d9994f67b163", "e519ba7e-85f1-4151-8d00-1310482532a4", "User", "USER" },
                    { "a68804ff-bc45-4aaf-8421-96f96acd14dd", "845e805f-74df-46d1-801f-f47de529b28d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { "ba344a0e-b2c7-409d-a3ce-06189a38efce", 0, "Some City", "fdf33a9e-17dc-4c49-9128-6a849cde6877", "ChewieYou@aol.com", false, "Chewbaca", "Solo", false, null, null, null, null, null, false, "7a0843ad-17f7-4369-8e11-b5cb9c298e58", "No States Here", "123 Millenium Falcon", false, "Chewie", "12345" },
                    { "d8d14bb7-1cbd-4ded-999c-2f684aafdc81", 0, "Some City", "fc3728c9-f3e4-433b-828c-a0fd9ce1f9a2", "IKnow@aol.com", false, "Han", "Solo", false, null, null, null, null, null, false, "09fc418e-246f-46d2-a291-1995b16d5fd9", "No States Here", "123 Millenium Falcon", false, "Han", "12345" },
                    { "a46be1d9-0ce7-44ff-920f-ed7c67d7bebb", 0, "Roach Motel", "8c522c86-e520-4788-a214-d0307b0eecd9", "SkippySucks@aol.com", false, "Joe", "Bishop", false, null, null, null, null, null, false, "8ae0f980-ecba-4af1-89ef-582fb0dea539", "Galaxy Far Away", "123 Valkyrie", false, "BishopRocks", "12345" },
                    { "55e04b82-d91f-4bd5-8b91-e87447413124", 0, "Roach Motel", "2c9ea568-ffa3-4fd2-a55f-890247d8fe88", "NoDirtyMonkeys@aol.com", false, "Skippy", "The Magnificent", false, null, null, null, null, null, false, "9c2219d3-b0a8-4c2a-aa03-65c8d6274d98", "Galaxy Far Away", "123 Valkyrie", false, "Skippy_The_Mag", "12345" }
                });
        }
    }
}
