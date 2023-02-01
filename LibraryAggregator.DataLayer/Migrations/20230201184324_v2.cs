using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgeGroup",
                table: "Library",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChartLink",
                table: "Library",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectorPhotoLink",
                table: "Library",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HistoryOfLibrary",
                table: "Library",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeGroup",
                table: "Library");

            migrationBuilder.DropColumn(
                name: "ChartLink",
                table: "Library");

            migrationBuilder.DropColumn(
                name: "DirectorPhotoLink",
                table: "Library");

            migrationBuilder.DropColumn(
                name: "HistoryOfLibrary",
                table: "Library");
        }
    }
}
