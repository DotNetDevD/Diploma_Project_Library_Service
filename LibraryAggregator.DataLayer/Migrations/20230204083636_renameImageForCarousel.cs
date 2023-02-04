using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class renameImageForCarousel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagesFourCorusel");

            migrationBuilder.CreateTable(
                name: "ImagesForCarousel",
                columns: table => new
                {
                    ImagesForCarouselId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibraryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesForCarousel", x => x.ImagesForCarouselId);
                    table.ForeignKey(
                        name: "FK_ImagesForCarousel_Library_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Library",
                        principalColumn: "LibraryId");
                });

            migrationBuilder.InsertData(
                table: "ImagesForCarousel",
                columns: new[] { "ImagesForCarouselId", "LibraryId", "Link" },
                values: new object[,]
                {
                    { 1, 1, "https://pbs.twimg.com/media/FCjAA-kXEAQbwqC?format=jpg&name=medium" },
                    { 2, 1, "https://extraguide.ru/images/blog/2020/12-12-3iz798-natsionalnaya-biblioteka-belarusi.jpeg" },
                    { 3, 1, "https://teenage.by/uploads/articlesImage/1552289035" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagesForCarousel_LibraryId",
                table: "ImagesForCarousel",
                column: "LibraryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagesForCarousel");

            migrationBuilder.CreateTable(
                name: "ImagesFourCorusel",
                columns: table => new
                {
                    ImagesFourCoruselId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibraryId = table.Column<int>(type: "int", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesFourCorusel", x => x.ImagesFourCoruselId);
                    table.ForeignKey(
                        name: "FK_ImagesFourCorusel_Library_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Library",
                        principalColumn: "LibraryId");
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

            migrationBuilder.CreateIndex(
                name: "IX_ImagesFourCorusel_LibraryId",
                table: "ImagesFourCorusel",
                column: "LibraryId");
        }
    }
}
