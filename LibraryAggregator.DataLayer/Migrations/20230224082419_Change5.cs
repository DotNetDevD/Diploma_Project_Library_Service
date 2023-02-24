using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Change5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "BookStatusId", "BooksLibraryId", "ClientId", "Code", "FinishDate", "StartDate" },
                values: new object[] { 1, 2, 1, 1, 300166, new DateTime(2023, 3, 3, 11, 2, 31, 989, DateTimeKind.Local).AddTicks(2505), new DateTime(2023, 2, 24, 11, 2, 31, 989, DateTimeKind.Local).AddTicks(2489) });
        }
    }
}
