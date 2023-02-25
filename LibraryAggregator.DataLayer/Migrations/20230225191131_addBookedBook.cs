using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addBookedBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookedBook",
                table: "BooksLibraries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 167401, new DateTime(2023, 3, 4, 22, 11, 31, 441, DateTimeKind.Local).AddTicks(8291), new DateTime(2023, 2, 25, 22, 11, 31, 441, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 1,
                column: "BookedBook",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 2,
                column: "BookedBook",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 3,
                column: "BookedBook",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 4,
                column: "BookedBook",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 5,
                column: "BookedBook",
                value: 0);

            migrationBuilder.UpdateData(
                table: "BooksLibraries",
                keyColumn: "BooksLibrariesId",
                keyValue: 6,
                column: "BookedBook",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedBook",
                table: "BooksLibraries");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 722049, new DateTime(2023, 3, 3, 15, 16, 21, 1, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 2, 24, 15, 16, 21, 1, DateTimeKind.Local).AddTicks(4569) });
        }
    }
}
