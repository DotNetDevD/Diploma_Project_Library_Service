using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Author__70DAFC34E9BADC14", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(23)", maxLength: 23, nullable: false),
                    CoverImgPath = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    PageCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Book__3DE0C207BE51473D", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Genre__0385057E1C92AF8D", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Library",
                columns: table => new
                {
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Library__A136475FA23EBF26", x => x.LibraryId);
                });

            migrationBuilder.CreateTable(
                name: "AuthorsBooks",
                columns: table => new
                {
                    AuthorsBooksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AuthorsB__E0C25E886755A2F4", x => x.AuthorsBooksId);
                    table.ForeignKey(
                        name: "FK__AuthorsBo__Autho__3B75D760",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId");
                    table.ForeignKey(
                        name: "FK__AuthorsBo__BookI__3C69FB99",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId");
                });

            migrationBuilder.CreateTable(
                name: "BooksGenres",
                columns: table => new
                {
                    BooksGenresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BooksGen__8D4DA176FE0124EF", x => x.BooksGenresId);
                    table.ForeignKey(
                        name: "FK__BooksGenr__BookI__46E78A0C",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId");
                    table.ForeignKey(
                        name: "FK__BooksGenr__Genre__47DBAE45",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId");
                });

            migrationBuilder.CreateTable(
                name: "BooksLibraries",
                columns: table => new
                {
                    BooksLibrariesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BooksLib__D9FCBEB6058BCAE3", x => x.BooksLibrariesId);
                    table.ForeignKey(
                        name: "FK__BooksLibr__BookI__412EB0B6",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId");
                    table.ForeignKey(
                        name: "FK__BooksLibr__Libra__4222D4EF",
                        column: x => x.LibraryId,
                        principalTable: "Library",
                        principalColumn: "LibraryId");
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { 1, "Лев", "Толстой", "Николаевич" },
                    { 2, "Антон", "Чехов", "Павлович" },
                    { 3, "Джефри", "Рихтер", null },
                    { 4, "Михаил", "Булгаков", "Афанасьевич" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "CoverImgPath", "Description", "ISBN", "PageCount", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "https://yandex.by/images/search?from=tabbar&text=%D0%90%D0%BD%D0%BD%D0%B0%20%D0%9A%D0%B0%D1%80%D0%B5%D0%BD%D0%B8%D0%BD%D0%B0%20%D0%9B%D0%B5%D0%B2%20%D0%A2%D0%BE%D0%BB%D1%81%D1%82%D0%BE%D0%B9%20%D0%BA%D0%BD%D0%B8%D0%B3%D0%B0&pos=2&img_url=http%3A%2F%2Fzvuk-knigi.ru%2Fuploads%2Fposts%2F2022-05%2F1653796476_2022-05-29_074809.jpg&rpt=simage&lr=157", "Любовь", "978-5-9268-2544-9", 1130, new DateTime(1877, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Анна Каренина" },
                    { 2, "https://yandex.by/images/search?from=tabbar&text=%D0%A7%D0%B5%D0%BB%D0%BE%D0%B2%D0%B5%D0%BA%20%D0%B2%20%D1%84%D1%83%D1%82%D0%BB%D1%8F%D1%80%D1%83&pos=2&img_url=http%3A%2F%2Flookaside.fbsbx.com%2Flookaside%2Fcrawler%2Fmedia%2F%3Fmedia_id%3D423641392452979&rpt=simage&lr=157", "Ошибки", "978-5-389-16173-3", 960, new DateTime(1898, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Человек в футляре" },
                    { 3, "https://yandex.by/images/search?from=tabbar&text=clr%20via%20c%23&pos=2&img_url=http%3A%2F%2Fplaybook.storage.yandexcloud.net%2Fiblock%2F659%2F65957062197947140c473640bdc33b7e%2F46772ad509f580644212f1610e05b107.jpg&rpt=simage&lr=157", "Хорошо", "978-5-7502-0348-2", 896, new DateTime(2008, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLR via C#" },
                    { 4, "https://yandex.by/images/search?text=%D0%BC%D0%B0%D1%81%D1%82%D0%B5%D1%80%20%D0%B8%20%D0%BC%D0%B0%D1%80%D0%B3%D0%B0%D1%80%D0%B8%D1%82%D0%B0%20%D0%BA%D0%BD%D0%B8%D0%B3%D0%B0&from=tabbar&pos=1&img_url=http%3A%2F%2Fmam4.ru%2Fresize%2F1280x-%2Fhttps%2Fwww.mam4.ru%2Fmedia%2Fupload%2Fuser%2F10807%2Fff%2F1631437479291.jpg%3Fh%3D68QJBhpTmqP34bJHHh-6ig&rpt=simage&lr=157", "Мастер крут", "978-5-04-102789-6", 1130, new DateTime(1966, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Мастер и Маргарита" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Type" },
                values: new object[,]
                {
                    { 1, "Любовный роман" },
                    { 2, "Модернизм в литературе" },
                    { 3, "Техническая литература" },
                    { 4, "роман" },
                    { 5, "рассказ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorsBooks_AuthorId",
                table: "AuthorsBooks",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorsBooks_BookId",
                table: "AuthorsBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "UQ__Book__447D36EA06ADE972",
                table: "Book",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksGenres_BookId",
                table: "BooksGenres",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksGenres_GenreId",
                table: "BooksGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksLibraries_BookId",
                table: "BooksLibraries",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksLibraries_LibraryId",
                table: "BooksLibraries",
                column: "LibraryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorsBooks");

            migrationBuilder.DropTable(
                name: "BooksGenres");

            migrationBuilder.DropTable(
                name: "BooksLibraries");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Library");
        }
    }
}
