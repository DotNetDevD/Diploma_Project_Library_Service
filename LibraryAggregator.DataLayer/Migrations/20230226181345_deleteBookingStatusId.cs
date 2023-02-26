using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class deleteBookingStatusId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingStatusId",
                table: "Booking");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "FinishDate", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 5, 21, 13, 44, 556, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 2, 26, 21, 13, 44, 556, DateTimeKind.Local).AddTicks(4400) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingStatusId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "BookingStatusId", "FinishDate", "StartDate" },
                values: new object[] { 2, new DateTime(2023, 3, 5, 0, 45, 6, 533, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 2, 26, 0, 45, 6, 533, DateTimeKind.Local).AddTicks(1005) });
        }
    }
}
