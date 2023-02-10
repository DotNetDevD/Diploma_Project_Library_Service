using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addPropertyUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "ImagesForCarousel",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "CoverImg",
                table: "Author",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "CoverImgPath",
                table: "ImagesForCarousel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImgPath",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Authors/lev-tolstoy.jpg", null });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Authors/anton-chekhov.jpg", null });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Authors/dzheffri-rihter.jpg", null });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Authors/mikhail-bulgakov.jpg ", null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Books/Anna_Karenina.jpg", null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Books/TheManInTheCase.jpg", null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Books/CLR-via-C.jpg", null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Books/The%20master%20and%20margarita.jpg", null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "https://localhost:7072/MyImages/Images/Books/The%20death%20of%20Ivan%20Ilyich.jpeg", null });

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 1,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "MyImages/Images/Libraries/natsionalnaya_biblioteka-1.jpg", null });

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 2,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "MyImages/Images/Libraries/natsionalnaya_biblioteka-2.jpg ", null });

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 3,
                columns: new[] { "CoverImgPath", "Url" },
                values: new object[] { "MyImages/Images/Libraries/natsionalnaya_biblioteka-3.jpg ", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImgPath",
                table: "ImagesForCarousel");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "CoverImgPath",
                table: "Author");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "ImagesForCarousel",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Author",
                newName: "CoverImg");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "CoverImg",
                value: "https://localhost:7072/MyImages/Images/Authors/lev-tolstoy.jpg ");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "CoverImg",
                value: "https://localhost:7072/MyImages/Images/Authors/anton-chekhov.jpg ");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "CoverImg",
                value: "https://localhost:7072/MyImages/Images/Authors/dzheffri-rihter.jpg ");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "CoverImg",
                value: "https://localhost:7072/MyImages/Images/Authors/mikhail-bulgakov.jpg ");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/Anna_Karenina.jpg ");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/TheManInTheCase.jpg ");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/CLR-via-C.jpg ");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/The%20master%20and%20margarita.jpg ");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                column: "CoverImgPath",
                value: "https://localhost:7072/MyImages/Images/Books/The%20death%20of%20Ivan%20Ilyich.jpeg ");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 1,
                column: "Link",
                value: "https://localhost:7072/MyImages/Images/Libraries/natsionalnaya_biblioteka-1.jpg ");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 2,
                column: "Link",
                value: "https://localhost:7072/MyImages/Images/Libraries/natsionalnaya_biblioteka-2.jpg ");

            migrationBuilder.UpdateData(
                table: "ImagesForCarousel",
                keyColumn: "ImagesForCarouselId",
                keyValue: 3,
                column: "Link",
                value: "https://localhost:7072/MyImages/Images/Libraries/natsionalnaya_biblioteka-3.jpg ");
        }
    }
}
