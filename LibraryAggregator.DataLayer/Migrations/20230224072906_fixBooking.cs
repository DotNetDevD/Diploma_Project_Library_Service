using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class fixBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 524666, new DateTime(2023, 3, 3, 10, 29, 5, 968, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 2, 24, 10, 29, 5, 968, DateTimeKind.Local).AddTicks(7397) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 808474, new DateTime(2023, 3, 2, 20, 12, 50, 331, DateTimeKind.Local).AddTicks(2144), new DateTime(2023, 2, 23, 20, 12, 50, 331, DateTimeKind.Local).AddTicks(2131) });
        }
    }
}
