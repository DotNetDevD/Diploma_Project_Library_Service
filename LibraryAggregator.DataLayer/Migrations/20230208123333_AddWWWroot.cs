using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddWWWroot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Anna_Karenina.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "~/Assets/Images/Anna_Karenina.jpg");
        }
    }
}
