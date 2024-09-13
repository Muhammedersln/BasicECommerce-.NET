using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BasicECommerce.Migrations
{
    /// <inheritdoc />
    public partial class seedPagesü : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Body", "Slug", "Title" },
                values: new object[,]
                {
                    { 1, "<h1>Welcome to our store!</h1>", "home", "Home" },
                    { 2, "<h1>About us</h1>", "about", "About" },
                    { 3, "<h1>Services</h1>", "services", "Services" },
                    { 4, "<h1>Contact us</h1>", "contact", "Contact" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
