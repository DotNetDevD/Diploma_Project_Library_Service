using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Change2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 701657, new DateTime(2023, 3, 3, 10, 55, 34, 257, DateTimeKind.Local).AddTicks(8968), new DateTime(2023, 2, 24, 10, 55, 34, 257, DateTimeKind.Local).AddTicks(8949) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 567016, new DateTime(2023, 3, 3, 10, 53, 15, 659, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 2, 24, 10, 53, 15, 659, DateTimeKind.Local).AddTicks(9697) });
        }
    }
}
