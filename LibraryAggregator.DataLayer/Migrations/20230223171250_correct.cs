using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class correct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BooksLibraries_BooksLibraryId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Booking");

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "BookStatusId", "BooksLibraryId", "ClientId", "Code", "FinishDate", "StartDate" },
                values: new object[] { 1, 2, 1, 1, 808474, new DateTime(2023, 3, 2, 20, 12, 50, 331, DateTimeKind.Local).AddTicks(2144), new DateTime(2023, 2, 23, 20, 12, 50, 331, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Booking",
                column: "BooksLibraryId",
                unique: true);

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
                name: "FK_Booking_BooksLibraries_BooksLibraryId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Booking");

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Booking",
                column: "BooksLibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_BooksLibraries_BooksLibraryId",
                table: "Booking",
                column: "BooksLibraryId",
                principalTable: "BooksLibraries",
                principalColumn: "BooksLibrariesId");
        }
    }
}
