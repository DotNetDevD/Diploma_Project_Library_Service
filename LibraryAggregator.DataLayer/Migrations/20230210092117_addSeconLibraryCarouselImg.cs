using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addSeconLibraryCarouselImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "MyImages/Images/Authors/mikhail-bulgakov.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/natsionalnaya_biblioteka-2.jpg");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "MyImages/Carousel/Images/Libraries/natsionalnaya_biblioteka-3.jpg");

            migrationBuilder.InsertData(
                table: "ImagesForCarousel",
                columns: new[] { "ImagesForCarouselId", "CoverImgPath", "LibraryId", "Url" },
                values: new object[,]
                {
                    { 4, "MyImages/Images/Libraries/imeni-yanki-kupaly-3.jpg", 2, null },
                    { 5, "MyImages/Images/Libraries/imeni-yanki-kupaly-2.jpg", 2, null },
                    { 6, "MyImages/Carousel/Images/Libraries/imeni-yanki-kupaly-3.jpg", 2, null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "MyImages/Images/Authors/mikhail-bulgakov.jpg ");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/natsionalnaya_biblioteka-2.jpg ");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "MyImages/Images/Libraries/natsionalnaya_biblioteka-3.jpg ");

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 1,
                columns: new[] { "CoverImgPath", "DirectorPhotoLink" },
                values: new object[] { "MyImages/Images/Libraries/natsionalnaya_biblioteka.jpg ", "MyImages/Images/Libraries/natsionalnaya_biblioteka.jpg " });

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 2,
                columns: new[] { "CoverImgPath", "DirectorPhotoLink" },
                values: new object[] { "MyImages/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg ", "MyImages/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg " });
        }
    }
}
