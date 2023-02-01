using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Library",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "ImagesFourCorusel",
                columns: table => new
                {
                    ImagesFourCoruselId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibraryId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "OperatingModes",
                columns: table => new
                {
                    OperatingModeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CleanUpDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibraryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingModes", x => x.OperatingModeId);
                    table.ForeignKey(
                        name: "FK_OperatingModes_Library_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Library",
                        principalColumn: "LibraryId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagesFourCorusel_LibraryId",
                table: "ImagesFourCorusel",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingModes_LibraryId",
                table: "OperatingModes",
                column: "LibraryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagesFourCorusel");

            migrationBuilder.DropTable(
                name: "OperatingModes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Library",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
