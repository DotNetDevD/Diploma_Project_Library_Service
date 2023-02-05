using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addBookSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "CoverImgPath", "Description", "ISBN", "PageCount", "PublishDate", "Title" },
                values: new object[] { 5, "https://ieducations.ru/wp-content/uploads/a/5/c/a5c57a4e7be1d79bb9a00a2ca6212d72.jpeg", "Повесть Л. Н. Толстого, над которой он работал с 1882 по 1886 год, внПовесть широко признана одной из вершин мировой литературы[1] и величайшим свершением Толстого в области малой литературной формы.Входит во Всемирную библиотеку(серия книг Норвежского книжного клуба)", "978-5-699-15152-3", 543, new DateTime(1886, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Смерть Ивана Ильича" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5);
        }
    }
}
