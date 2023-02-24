using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Change3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 655252, new DateTime(2023, 3, 3, 10, 59, 2, 823, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 2, 24, 10, 59, 2, 823, DateTimeKind.Local).AddTicks(3233) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "Code", "FinishDate", "StartDate" },
                values: new object[] { 701657, new DateTime(2023, 3, 3, 10, 55, 34, 257, DateTimeKind.Local).AddTicks(8968), new DateTime(2023, 2, 24, 10, 55, 34, 257, DateTimeKind.Local).AddTicks(8949) });
        }
    }
}
