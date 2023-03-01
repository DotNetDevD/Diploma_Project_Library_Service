using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class FIX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BooksLibraries",
                columns: new[] { "BooksLibrariesId", "BookId", "BookedBook", "Count", "FreeBook", "IsFreeBook", "LibraryId" },
                values: new object[,]
                {
                    { 1, 1, 0, 2, 0, true, 1 },
                    { 2, 2, 0, 3, 0, true, 1 },
                    { 3, 3, 0, 1, 0, true, 1 },
                    { 4, 4, 0, 2, 0, true, 1 },
                    { 5, 2, 0, 2, 0, true, 2 },
                    { 6, 1, 0, 3, 0, true, 2 }
                });
        }
    }
}
