using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addAuthorSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuthorsBooks",
                columns: new[] { "AuthorsBooksId", "AuthorId", "BookId" },
                values: new object[] { 5, 1, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorsBooks",
                keyColumn: "AuthorsBooksId",
                keyValue: 5);
        }
    }
}
