using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Library",
                columns: new[] { "LibraryId", "Address", "AgeGroup", "ChartLink", "DirectorPhotoLink", "Email", "HistoryOfLibrary", "Name", "PhoneNumber" },
                values: new object[] { 1, "просп.Независимости, 11б", "Нет ограничений ", "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48", "https://yandex.by/images/search?pos=1&img_url=http%3A%2F%2Fculturalforum.ru%2Fcontent%2Fparticipants%2Fcc%2Fccbd7c9088e9e70148120c9eaaa5064b-cropped.jpg&text=%D0%9A%D0%BD%D0%B8%D0%B6%D0%BD%D0%B8%D0%BA%D0%BE%D0%B2%D0%B0%20%D0%9E%D0%BA%D1%81%D0%B0%D0%BD%D0%B0%20%D0%AE%D1%80%D1%8C%D0%B5%D0%B2%D0%BD%D0%B0&lr=157&rpt=simage&source=serp", "www.nlb.by", "Национальная библиотека Беларуси (НББ) была основана постановлением Совета народных комиссаров БССР в 1922 году как Белорусская государственная и университетская библиотека Белорусского государственного университета (БГУ). На момент открытия фонды библиотеки насчитывали всего 60 тысяч экземпляров, которыми пользовались 1,1 тысячи человек. Первым собственным зданием библиотеки стал Юбилейный дом на Захарьевской улице (ныне — проспект Независимости). Постановлением СНК БССР от 14 мая 1926 году библиотека была выведена из состава БГУ и реорганизована в Белорусскую государственную библиотеку. В 1932 году библиотеке было присвоено имя В. И. Ленина. В тот же год библиотека получила новое здание архитектора Г. Лаврова в конструктивистском стиле. ", "Национальная библиотека Минска", "+375 17 368-37-37" });

            migrationBuilder.InsertData(
                table: "BooksLibraries",
                columns: new[] { "BooksLibrariesId", "BookId", "LibraryId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "ImagesFourCorusel",
                columns: new[] { "ImagesFourCoruselId", "LibraryId", "Link" },
                values: new object[,]
                {
                    { 1, 1, "https://nashaniva.com/photos/generated/fb249647.png" },
                    { 2, 1, "http://knigoplaneta.ru/wp-content/uploads/2015/05/DSC_0253.jpg" },
                    { 3, 1, "http://s4.fotokto.ru/photo/full/492/4927138.jpg" }
                });

            migrationBuilder.InsertData(
                table: "OperatingModes",
                columns: new[] { "OperatingModeId", "CleanUpDay", "EndWork", "LibraryId", "StartWork" },
                values: new object[,]
                {
                    { 1, "Понедельник", "20:00", 1, "8:00" },
                    { 2, "Пятница", "22:00", 1, "10:00" },
                    { 3, "Среда", "22:00", 1, "10:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImagesFourCorusel",
                keyColumn: "ImagesFourCoruselId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ImagesFourCorusel",
                keyColumn: "ImagesFourCoruselId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ImagesFourCorusel",
                keyColumn: "ImagesFourCoruselId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperatingModes",
                keyColumn: "OperatingModeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperatingModes",
                keyColumn: "OperatingModeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperatingModes",
                keyColumn: "OperatingModeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Library",
                keyColumn: "LibraryId",
                keyValue: 1);
        }
    }
}
