using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_BooksLibraries_BooksLibraryId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksLibraries_BookStatuses_BookStatusId",
                table: "BooksLibraries");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Bookings_BookingId",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_BookingId",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameTable(
                name: "BookStatuses",
                newName: "BookStatus");

            migrationBuilder.RenameTable(
                name: "BooksLibraries",
                newName: "BooksLibrarie");

            migrationBuilder.RenameTable(
                name: "BooksGenres",
                newName: "BooksGenre");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameTable(
                name: "AuthorsBooks",
                newName: "AuthorsBook");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_PhoneNumber",
                table: "Client",
                newName: "IX_Client_PhoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_Email",
                table: "Client",
                newName: "IX_Client_Email");

            migrationBuilder.RenameIndex(
                name: "IX_BooksLibraries_LibraryId",
                table: "BooksLibrarie",
                newName: "IX_BooksLibrarie_LibraryId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksLibraries_BookStatusId",
                table: "BooksLibrarie",
                newName: "IX_BooksLibrarie_BookStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksLibraries_BookId",
                table: "BooksLibrarie",
                newName: "IX_BooksLibrarie_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenres_GenreId",
                table: "BooksGenre",
                newName: "IX_BooksGenre_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenres_BookId",
                table: "BooksGenre",
                newName: "IX_BooksGenre_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_BooksLibraryId",
                table: "Booking",
                newName: "IX_Booking_BooksLibraryId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorsBooks_BookId",
                table: "AuthorsBook",
                newName: "IX_AuthorsBook_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorsBooks_AuthorId",
                table: "AuthorsBook",
                newName: "IX_AuthorsBook_AuthorId");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "BookingId");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "ClientId", "Code" },
                values: new object[] { 0, 704648 });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                columns: new[] { "ClientId", "Code" },
                values: new object[] { 0, 648481 });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3,
                columns: new[] { "ClientId", "Code" },
                values: new object[] { 0, 328949 });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 4,
                columns: new[] { "ClientId", "Code" },
                values: new object[] { 0, 901259 });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ClientId",
                table: "Booking",
                column: "ClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_BooksLibrarie_BooksLibraryId",
                table: "Booking",
                column: "BooksLibraryId",
                principalTable: "BooksLibrarie",
                principalColumn: "BooksLibrariesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Client_ClientId",
                table: "Booking",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksLibrarie_BookStatus_BookStatusId",
                table: "BooksLibrarie",
                column: "BookStatusId",
                principalTable: "BookStatus",
                principalColumn: "BookStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BooksLibrarie_BooksLibraryId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Client_ClientId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksLibrarie_BookStatus_BookStatusId",
                table: "BooksLibrarie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ClientId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Booking");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameTable(
                name: "BookStatus",
                newName: "BookStatuses");

            migrationBuilder.RenameTable(
                name: "BooksLibrarie",
                newName: "BooksLibraries");

            migrationBuilder.RenameTable(
                name: "BooksGenre",
                newName: "BooksGenres");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "AuthorsBook",
                newName: "AuthorsBooks");

            migrationBuilder.RenameIndex(
                name: "IX_Client_PhoneNumber",
                table: "Clients",
                newName: "IX_Clients_PhoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Client_Email",
                table: "Clients",
                newName: "IX_Clients_Email");

            migrationBuilder.RenameIndex(
                name: "IX_BooksLibrarie_LibraryId",
                table: "BooksLibraries",
                newName: "IX_BooksLibraries_LibraryId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksLibrarie_BookStatusId",
                table: "BooksLibraries",
                newName: "IX_BooksLibraries_BookStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksLibrarie_BookId",
                table: "BooksLibraries",
                newName: "IX_BooksLibraries_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenre_GenreId",
                table: "BooksGenres",
                newName: "IX_BooksGenres_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenre_BookId",
                table: "BooksGenres",
                newName: "IX_BooksGenres_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_BooksLibraryId",
                table: "Bookings",
                newName: "IX_Bookings_BooksLibraryId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorsBook_BookId",
                table: "AuthorsBooks",
                newName: "IX_AuthorsBooks_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorsBook_AuthorId",
                table: "AuthorsBooks",
                newName: "IX_AuthorsBooks_AuthorId");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "BookingId");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "Code",
                value: 542440);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "Code",
                value: 864426);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "Code",
                value: 784050);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "Code",
                value: 278332);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BookingId",
                table: "Clients",
                column: "BookingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_BooksLibraries_BooksLibraryId",
                table: "Bookings",
                column: "BooksLibraryId",
                principalTable: "BooksLibraries",
                principalColumn: "BooksLibrariesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksLibraries_BookStatuses_BookStatusId",
                table: "BooksLibraries",
                column: "BookStatusId",
                principalTable: "BookStatuses",
                principalColumn: "BookStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Bookings_BookingId",
                table: "Clients",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
