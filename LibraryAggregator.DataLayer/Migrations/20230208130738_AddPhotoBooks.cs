using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/TheManInTheCase.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/CLR%20via%20C#.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/The%20master%20and%20margarita.webp");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/The%20death%20of%20Ivan%20Ilyich.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "https://images.onlinetestpad.com/e7/1c/4b158ed94c1280f7d5598a4db559.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "https://i.simpalsmedia.com/999.md/BoardImages/900x900/e059d58b94220cddeed88f43785317f2.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "https://avatars.dzeninfra.ru/get-zen_doc/2816669/pub_5ee20b1557defd169d7c3d5d_5ee20b4247f3067b1b8556af/scale_1200");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "CoverImgPath",
                value: "https://ieducations.ru/wp-content/uploads/a/5/c/a5c57a4e7be1d79bb9a00a2ca6212d72.jpeg");
        }
    }
}
