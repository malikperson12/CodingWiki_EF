using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InsertSeedDataForBookAndPublisher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Publisher_Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Chicagao", "Pub 1 Jimmy" },
                    { 2, "New York", "Pub 2 John" },
                    { 3, "Hawaii", "Pub 3 Ben" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Book_Id", "ISBN", "Price", "Publisher_Id", "Title" },
                values: new object[,]
                {
                    { 1, "123B12", 10.99m, 1, "Spider without Duty" },
                    { 2, "12123B12", 11.99m, 1, "Fortune of Time" },
                    { 3, "77652", 20.99m, 2, "Fake Sunday" },
                    { 4, "CC12B12", 25.99m, 3, "Cookie Jar" },
                    { 5, "90392B33", 40.99m, 3, "Cloudy Forest" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Book_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Publisher_Id",
                keyValue: 3);
        }
    }
}
