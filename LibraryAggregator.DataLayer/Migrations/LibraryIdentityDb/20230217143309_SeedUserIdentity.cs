using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAggregator.DataLayer.Migrations.LibraryIdentityDb
{
    /// <inheritdoc />
    public partial class SeedUserIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50abc4ee-3d24-40f4-918d-7440899eb2a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7851d05e-322e-4187-a5b0-fdadcb045fb2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "648cbc2f-33e0-4f5c-a946-20794316b847", "2", "User", "User" },
                    { "ef97e0f9-6aeb-4ed5-a22b-325c1e6714ae", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "648cbc2f-33e0-4f5c-a946-20794316b847");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef97e0f9-6aeb-4ed5-a22b-325c1e6714ae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50abc4ee-3d24-40f4-918d-7440899eb2a1", "2", "User", "User" },
                    { "7851d05e-322e-4187-a5b0-fdadcb045fb2", "1", "Admin", "Admin" }
                });
        }
    }
}
