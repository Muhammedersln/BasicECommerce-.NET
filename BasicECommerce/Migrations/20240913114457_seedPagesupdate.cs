using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasicECommerce.Migrations
{
    /// <inheritdoc />
    public partial class seedPagesupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Body",
                value: "Welcome to our store!");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Body",
                value: "About us");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Body",
                value: "Services");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Body",
                value: "Contact us");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Body",
                value: "<h1>Welcome to our store!</h1>");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Body",
                value: "<h1>About us</h1>");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Body",
                value: "<h1>Services</h1>");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Body",
                value: "<h1>Contact us</h1>");
        }
    }
}
