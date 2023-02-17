using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryAggregator.DataLayer.Migrations.LibraryIdentityDb
{
    /// <inheritdoc />
    public partial class SeedRoleIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50abc4ee-3d24-40f4-918d-7440899eb2a1", "2", "User", "User" },
                    { "7851d05e-322e-4187-a5b0-fdadcb045fb2", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50abc4ee-3d24-40f4-918d-7440899eb2a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7851d05e-322e-4187-a5b0-fdadcb045fb2");
        }
    }
}
