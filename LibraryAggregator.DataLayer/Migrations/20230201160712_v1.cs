using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuthorsBooks",
                columns: new[] { "AuthorsBooksId", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "BooksGenres",
                columns: new[] { "BooksGenresId", "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 2, 5 },
                    { 3, 4, 1 },
                    { 4, 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumn: "AuthorsBooksId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumn: "AuthorsBooksId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumn: "AuthorsBooksId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumn: "AuthorsBooksId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BooksGenres",
                keyColumn: "BooksGenresId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BooksGenres",
                keyColumn: "BooksGenresId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BooksGenres",
                keyColumn: "BooksGenresId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BooksGenres",
                keyColumn: "BooksGenresId",
                keyValue: 4);
        }
    }
}
