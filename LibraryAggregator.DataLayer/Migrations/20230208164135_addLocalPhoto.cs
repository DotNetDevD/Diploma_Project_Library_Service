using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addLocalPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "CoverImg",
                value: "https://localhost:7072/MyImages/Images/Authors/dzheffri-rihter.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "CoverImg",
                value: "https://localhost:7072/MyImages/Images/Authors/mikhail-bulgakov.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "CoverImg",
                value: "https://localhost:7072/MyImages/Images/dzheffri-rihter.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "CoverImg",
                value: "https://localhost:7072/MyImages/Images/mikhail-bulgakov.jpg");
        }
    }
}
