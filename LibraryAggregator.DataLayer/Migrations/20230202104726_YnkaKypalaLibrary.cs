using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class YnkaKypalaLibrary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Library",
                columns: new[] { "LibraryId", "Address", "AgeGroup", "ChartLink", "DirectorPhotoLink", "Email", "HistoryOfLibrary", "Name", "PhoneNumber" },
                values: new object[] { 2, "Улица Веры Хоружей 16", "Нет ограничений", "https://publib.by/wp-content/uploads/2022/06/czentralnaya-biblioteka-imeni-yanki-kupaly-1.jpg", null, "www.publib.by/", "Сёння Цэнтральная бібліятэка імя Янкі Купалы – гэта: ТРАДЫЦЫЯ БЫЦЬ ПАТРЭБНАЙ", "Библиотека им. Янки Купалы", "8 017 242-21-15" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 2);
        }
    }
}
