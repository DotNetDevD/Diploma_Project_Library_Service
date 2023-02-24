using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Change10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BookStatus_BookStatusId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BooksLibraries_BooksLibraryId",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BookStatus",
                table: "BookStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookStatus",
                table: "BookStatus",
                column: "BookStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_BookStatus_BookStatusId",
                table: "Booking",
                column: "BookStatusId",
                principalTable: "BookStatus",
                principalColumn: "BookStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_BooksLibraries_BooksLibraryId",
                table: "Booking",
                column: "BooksLibraryId",
                principalTable: "BooksLibraries",
                principalColumn: "BooksLibrariesId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BookStatus_BookStatusId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BooksLibraries_BooksLibraryId",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookStatus",
                table: "BookStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BookStatus",
                table: "BookStatus",
                column: "BookStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_BookStatus_BookStatusId",
                table: "Booking",
                column: "BookStatusId",
                principalTable: "BookStatus",
                principalColumn: "BookStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_BooksLibraries_BooksLibraryId",
                table: "Booking",
                column: "BooksLibraryId",
                principalTable: "BooksLibraries",
                principalColumn: "BooksLibrariesId");
        }
    }
}
