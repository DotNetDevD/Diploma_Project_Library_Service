using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class correctUrlImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "Assets/Images/Authors/lev-tolstoy.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "Assets/Images/Authors/anton-chekhov.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "Assets/Images/Authors/dzheffri-rihter.jpg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "Assets/Images/Authors/mikhail-bulgakov.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "Assets/Images/Books/Anna_Karenina.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "Assets/Images/Books/TheManInTheCase.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "Assets/Images/Books/CLR-via-C.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "Assets/Images/Books/The%20master%20and%20margarita.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "CoverImgPath",
                value: "Assets/Images/Books/The%20death%20of%20Ivan%20Ilyich.jpeg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-1.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-2.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-3.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-3.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 5,
                column: "CoverImgPath",
                value: "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-2.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 6,
                column: "CoverImgPath",
                value: "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-3.jpg");

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 1,
                columns: new[] { "CoverImgPath", "DirectorPhotoLink" },
                values: new object[] { "Assets/Images/Libraries/natsionalnaya_biblioteka.jpg", "Assets/Images/Libraries/natsionalnaya_biblioteka.jpg" });

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 2,
                columns: new[] { "CoverImgPath", "DirectorPhotoLink" },
                values: new object[] { "Assets/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg", "Assets/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "MyImages/Images/Authors/mikhail-bulgakov.jpg");

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
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/Carousel/natsionalnaya_biblioteka-1.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/Carousel/natsionalnaya_biblioteka-2.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/Carousel/natsionalnaya_biblioteka-3.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/Carousel/imeni-yanki-kupaly-3.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 5,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/Carousel/imeni-yanki-kupaly-2.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 6,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/Carousel/imeni-yanki-kupaly-3.jpg");

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 1,
                columns: new[] { "CoverImgPath", "DirectorPhotoLink" },
                values: new object[] { "MyImages/Images/Libraries/natsionalnaya_biblioteka.jpg", "MyImages/Images/Libraries/natsionalnaya_biblioteka.jpg" });

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 2,
                columns: new[] { "CoverImgPath", "DirectorPhotoLink" },
                values: new object[] { "MyImages/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg", "MyImages/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg" });
        }
    }
}
