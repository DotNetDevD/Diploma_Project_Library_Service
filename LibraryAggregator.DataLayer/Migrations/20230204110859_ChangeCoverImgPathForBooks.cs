using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCoverImgPathForBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "https://cache3.youla.io/files/images/780_780/5b/a5/5ba5eb0780e08eb32e7dd903.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "https://images.onlinetestpad.com/e7/1c/4b158ed94c1280f7d5598a4db559.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "https://i.simpalsmedia.com/999.md/BoardImages/900x900/e059d58b94220cddeed88f43785317f2.jpg");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "https://avatars.dzeninfra.ru/get-zen_doc/2816669/pub_5ee20b1557defd169d7c3d5d_5ee20b4247f3067b1b8556af/scale_1200");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CoverImgPath",
                value: "https://yandex.by/images/search?from=tabbar&text=%D0%90%D0%BD%D0%BD%D0%B0%20%D0%9A%D0%B0%D1%80%D0%B5%D0%BD%D0%B8%D0%BD%D0%B0%20%D0%9B%D0%B5%D0%B2%20%D0%A2%D0%BE%D0%BB%D1%81%D1%82%D0%BE%D0%B9%20%D0%BA%D0%BD%D0%B8%D0%B3%D0%B0&pos=2&img_url=http%3A%2F%2Fzvuk-knigi.ru%2Fuploads%2Fposts%2F2022-05%2F1653796476_2022-05-29_074809.jpg&rpt=simage&lr=157");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CoverImgPath",
                value: "https://yandex.by/images/search?from=tabbar&text=%D0%A7%D0%B5%D0%BB%D0%BE%D0%B2%D0%B5%D0%BA%20%D0%B2%20%D1%84%D1%83%D1%82%D0%BB%D1%8F%D1%80%D1%83&pos=2&img_url=http%3A%2F%2Flookaside.fbsbx.com%2Flookaside%2Fcrawler%2Fmedia%2F%3Fmedia_id%3D423641392452979&rpt=simage&lr=157");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CoverImgPath",
                value: "https://yandex.by/images/search?from=tabbar&text=clr%20via%20c%23&pos=2&img_url=http%3A%2F%2Fplaybook.storage.yandexcloud.net%2Fiblock%2F659%2F65957062197947140c473640bdc33b7e%2F46772ad509f580644212f1610e05b107.jpg&rpt=simage&lr=157");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "CoverImgPath",
                value: "https://yandex.by/images/search?text=%D0%BC%D0%B0%D1%81%D1%82%D0%B5%D1%80%20%D0%B8%20%D0%BC%D0%B0%D1%80%D0%B3%D0%B0%D1%80%D0%B8%D1%82%D0%B0%20%D0%BA%D0%BD%D0%B8%D0%B3%D0%B0&from=tabbar&pos=1&img_url=http%3A%2F%2Fmam4.ru%2Fresize%2F1280x-%2Fhttps%2Fwww.mam4.ru%2Fmedia%2Fupload%2Fuser%2F10807%2Fff%2F1631437479291.jpg%3Fh%3D68QJBhpTmqP34bJHHh-6ig&rpt=simage&lr=157");
        }
    }
}
