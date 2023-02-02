using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class restructionLibrary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Library",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDiscription",
                table: "Library",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 1,
                columns: new[] { "CoverImage", "DirectorPhotoLink", "ShortDiscription" },
                values: new object[] { "https://www.belarus.by/dadvimages/001339_318669.jpg", "https://www.belarus.by/dadvimages/001339_318669.jpg", "Национальная библиотека Беларуси (НББ)" });

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 2,
                columns: new[] { "ChartLink", "CoverImage", "DirectorPhotoLink", "ShortDiscription" },
                values: new object[] { "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48", "https://publib.by/wp-content/uploads/2022/06/czentralnaya-biblioteka-imeni-yanki-kupaly-1.jpg", "https://publib.by/wp-content/uploads/2022/06/czentralnaya-biblioteka-imeni-yanki-kupaly-1.jpg", "Цэнтральная бібліятэка імя Янкі Купалы" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Library");

            migrationBuilder.DropColumn(
                name: "ShortDiscription",
                table: "Library");

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 1,
                column: "DirectorPhotoLink",
                value: "https://yandex.by/images/search?pos=1&img_url=http%3A%2F%2Fculturalforum.ru%2Fcontent%2Fparticipants%2Fcc%2Fccbd7c9088e9e70148120c9eaaa5064b-cropped.jpg&text=%D0%9A%D0%BD%D0%B8%D0%B6%D0%BD%D0%B8%D0%BA%D0%BE%D0%B2%D0%B0%20%D0%9E%D0%BA%D1%81%D0%B0%D0%BD%D0%B0%20%D0%AE%D1%80%D1%8C%D0%B5%D0%B2%D0%BD%D0%B0&lr=157&rpt=simage&source=serp");

            migrationBuilder.UpdateData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 2,
                columns: new[] { "ChartLink", "DirectorPhotoLink" },
                values: new object[] { "https://publib.by/wp-content/uploads/2022/06/czentralnaya-biblioteka-imeni-yanki-kupaly-1.jpg", null });
        }
    }
}
