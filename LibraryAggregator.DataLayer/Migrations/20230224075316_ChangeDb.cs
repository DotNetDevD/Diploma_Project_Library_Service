using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDb : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Booking");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 567016, new DateTime(2023, 3, 3, 10, 53, 15, 659, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 2, 24, 10, 53, 15, 659, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Booking",
                column: "BooksLibraryId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BookStatus_BookStatusId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BooksLibraries_BooksLibraryId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Booking");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 524666, new DateTime(2023, 3, 3, 10, 29, 5, 968, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 2, 24, 10, 29, 5, 968, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Booking",
                column: "BooksLibraryId",
                unique: true);

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
    }
}
