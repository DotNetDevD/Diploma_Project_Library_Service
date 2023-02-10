using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class correctSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "MyImages/Images/Authors/lev-tolstoy.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "MyImages/Images/Authors/anton-chekhov.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "MyImages/Images/Authors/dzheffri-rihter.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "MyImages/Images/Authors/mikhail-bulgakov.jpg ");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "MyImages/Images/Books/Anna_Karenina.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "MyImages/Images/Books/TheManInTheCase.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "MyImages/Images/Books/CLR-via-C.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "MyImages/Images/Books/The%20master%20and%20margarita.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "CoverImgPath",
                value: "MyImages/Images/Books/The%20death%20of%20Ivan%20Ilyich.jpeg");

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 1,
                columns: new[] { "CoverImage", "DirectorPhotoLink" },
                values: new object[] { "MyImages/Images/Libraries/natsionalnaya_biblioteka.jpg ", "MyImages/Images/Libraries/natsionalnaya_biblioteka.jpg " });

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 2,
                columns: new[] { "CoverImage", "DirectorPhotoLink" },
                values: new object[] { "MyImages/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg ", "MyImages/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg " });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Authors/lev-tolstoy.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Authors/anton-chekhov.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Authors/dzheffri-rihter.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Authors/mikhail-bulgakov.jpg ");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/Anna_Karenina.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/TheManInTheCase.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/CLR-via-C.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/The%20master%20and%20margarita.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/The%20death%20of%20Ivan%20Ilyich.jpeg");

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 1,
                columns: new[] { "CoverImage", "DirectorPhotoLink" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Libraries/natsionalnaya_biblioteka.jpg ", "https://localhost:7072/MyImages/Images/Libraries/natsionalnaya_biblioteka.jpg " });

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 2,
                columns: new[] { "CoverImage", "DirectorPhotoLink" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg ", "https://localhost:7072/MyImages/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg " });
        }
    }
}
