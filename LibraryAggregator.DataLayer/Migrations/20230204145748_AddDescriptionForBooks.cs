using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAggregator.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionForBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Description",
                value: "Роман Льва Толстого о трагической любви замужней дамы Анны Карениной и \r\nблестящего офицера Алексея Вронского на фоне счастливой семейной жизни дворян Константина Лёвина\r\n и Кити Щербацкой. Масштабная картина нравов и быта дворянской среды Петербурга и Москвы второй половины XIX века, \r\nсочетающая философские размышления авторского alter ego Лёвина с передовыми в русской литературе психологическими зарисовками, а также сценами из жизни крестьян.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Description",
                value: "Серия «Маленькая трилогия», состоящая из трёх рассказов — «Человек в футляре», \r\n«Крыжовник», «О любви» — не должна была оканчиваться рассказом «О любви». \r\nВо время написания рассказов произошёл спад активности творчества, а позднее Чехова отвлекло заболевание туберкулезом.\r\nНад рассказом Чехов работал в мае — июне 1898 года в Мелихове. В начале июня 1898 года рассказ готовился к печати, а 15 июня 1898 года рукопись была отправлена в ж");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Description",
                value: "Эта книга, выходящая в третьем издании и уже ставшая классическим учебником по программированию,\r\n подробно описывает внутреннее устройство и функционирование общеязыковой исполняющей среды (CLR) Microsoft .NET Framework версии 4.0. \r\nНаписанная признанным экспертом в области программирования Джеффри Рихтером, много лет являющимся консультантом команды разработчиков .NET Framework компании Microsoft, \r\nкнига научит вас создавать по-настоящему надежные приложения любого вида, в том числе с использованием Microsoft Silverlight, ASP.NET, Windows Presentation Foundation и т.д.\r\nТретье издание полностью обновлено в соответствии со спецификацией платформы .NET Framework 4.0 и принципами многоядерного программирования.");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "Description",
                value: "«Ма́стер и Маргари́та» — роман Михаила Афанасьевича Булгакова, работа над которым началась в декабре 1928 года и продолжалась вплоть до смерти писателя в марте 1940 года.\r\n Роман относится к незавершённым произведениям; редактирование и сведение воедино черновых записей осуществляла после смерти мужа вдова писателя — Елена Сергеевна. \r\nПервая версия романа, имевшая названия «Копыто инженера», «Чёрный маг» и другие, была уничтожена Булгаковым в 1930 году. \r\nВ последующих редакциях среди героев произведения появились автор романа о Понтии Пилате и его возлюбленная. Окончательное название — «Мастер и Маргарита» — оформилось в 1937 году.\r\n\r\nПервая публикация произведения в сокращённом виде была осуществлена в 1966—1967 годах (журнал «Москва», предисловие Константина Симонова, послесловие Абрама Вулиса). \r\nПервое полное издание книги на русском языке вышло в 1967 году (издательство «YMCA-Press», Париж).\r\n В СССР книжный вариант без купюр увидел свет в 1973 году (издательство «Художественная литература», тираж 30 000 экземпляров). \r\nПроизведение неоднократно экранизировано и инсценировано.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Description",
                value: "Любовь");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Description",
                value: "Ошибки");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "Description",
                value: "Хорошо");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "Description",
                value: "Мастер крут");
        }
    }
}
