using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Change14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Booking_BookStatusId",
                table: "Booking");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BookStatusId",
                table: "Booking",
                column: "BookStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Booking_BookStatusId",
                table: "Booking");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BookStatusId",
                table: "Booking",
                column: "BookStatusId",
                unique: true);
        }
    }
}
