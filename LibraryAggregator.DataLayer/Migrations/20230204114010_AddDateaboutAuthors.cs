using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddDateaboutAuthors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImg",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Author",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1,
                columns: new[] { "Biography", "CoverImg", "DateOfBirth" },
                values: new object[] { "Один из наиболее широко известных русских писателей и мыслителей, почитаемый как один из величайших писателей мира. Участник обороны Севастополя. Просветитель, публицист, религиозный мыслитель, чьё авторитетное мнение послужило причиной возникновения нового религиозно-нравственного течения — толстовства. Член-корреспондент Императорской Академии наук (1873), почётный академик по разряду изящной словесности (1900).", "https://cdnn1.inosmi.ru/img/15742/32/157423296_0:0:0:0_1240x0_80_0_0_9490582cecae850e760624f47427f8b7.jpg", new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2,
                columns: new[] { "Biography", "CoverImg", "DateOfBirth" },
                values: new object[] { "Антон Павлович Чехов родился в Таганроге. Обучался в греческой школе, затем в классической гимназии. В 1876 году отец Чехова разорился и был вынужден бежать в Москву, а Антон Павлович остался в Таганроге. Свои первые литературные работы Чехов под разными псевдонимами посылает в столичные журналы; среди его первых произведений не сохранившиеся комедии \"Нашла коса на камень\" и \"Недаром курица пела\", в так же солидная драма \"Безотцовщина\".", "https://s13.stc.yc.kpcdn.net/share/i/12/10343093/wr-960.webp", new DateTime(1860, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "Biography", "CoverImg", "DateOfBirth" },
                values: new object[] { "Джеффри Рихтер – программист, автор самых известных книг о Win32 и .NET. Рихтер – один из учредителей компании Wintellect, занимающейся подготовкой IT-специалистов и предоставлением консалтинговых услуг фирмам-разработчикам ПО. Рихтер работал с такими компаниями как Intel, DreamWorks и Microsoft.", "https://m.media-amazon.com/images/I/815BcutlJoL._SY600_.jpg", new DateTime(1964, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "Biography", "CoverImg", "DateOfBirth" },
                values: new object[] { "Учился в Первой Киевской гимназии, позднее — на медицинском факультете Киевского университета. Первую пробу пера совершил в семилетнем возрасте, написав рассказ «Похождения Светланы».", "https://rus.team/images/article/4579/2019-03-07-373_15367-1_766329.webp", new DateTime(1891, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "CoverImg",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Author");
        }
    }
}
