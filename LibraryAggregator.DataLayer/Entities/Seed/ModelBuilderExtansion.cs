using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LibraryAggregator.DataLayer.Entities.Seed
{
    public static class ModelBuilderExtansion
    {
        public static void SeedBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Анна Каренина",
                    Isbn = "978-5-9268-2544-9",
                    CoverImgPath = "https://yandex.by/images/search?from=tabbar&text=%D0%90%D0%BD%D0%BD%D0%B0%20%D0%9A%D0%B0%D1%80%D0%B5%D0%BD%D0%B8%D0%BD%D0%B0%20%D0%9B%D0%B5%D0%B2%20%D0%A2%D0%BE%D0%BB%D1%81%D1%82%D0%BE%D0%B9%20%D0%BA%D0%BD%D0%B8%D0%B3%D0%B0&pos=2&img_url=http%3A%2F%2Fzvuk-knigi.ru%2Fuploads%2Fposts%2F2022-05%2F1653796476_2022-05-29_074809.jpg&rpt=simage&lr=157",
                    Description = "Любовь",
                    PageCount = 1130,
                    PublishDate = new DateTime(1877, 04, 17)

                },

                 new Book
                 {
                     BookId = 2,
                     Title = "Человек в футляре",
                     Isbn = "978-5-389-16173-3",
                     CoverImgPath = "https://yandex.by/images/search?from=tabbar&text=%D0%A7%D0%B5%D0%BB%D0%BE%D0%B2%D0%B5%D0%BA%20%D0%B2%20%D1%84%D1%83%D1%82%D0%BB%D1%8F%D1%80%D1%83&pos=2&img_url=http%3A%2F%2Flookaside.fbsbx.com%2Flookaside%2Fcrawler%2Fmedia%2F%3Fmedia_id%3D423641392452979&rpt=simage&lr=157",
                     Description = "Ошибки",
                     PageCount = 960,
                     PublishDate = new DateTime(1898, 06, 15)
                 },

                  new Book
                  {
                      BookId = 3,
                      Title = "CLR via C#",
                      Isbn = "978-5-7502-0348-2",
                      CoverImgPath = "https://yandex.by/images/search?from=tabbar&text=clr%20via%20c%23&pos=2&img_url=http%3A%2F%2Fplaybook.storage.yandexcloud.net%2Fiblock%2F659%2F65957062197947140c473640bdc33b7e%2F46772ad509f580644212f1610e05b107.jpg&rpt=simage&lr=157",
                      Description = "Хорошо",
                      PageCount = 896,
                      PublishDate = new DateTime(2008, 02, 11)
                  },

                   new Book
                   {
                       BookId = 4,
                       Title = "Мастер и Маргарита",
                       Isbn = "978-5-04-102789-6",
                       CoverImgPath = "https://yandex.by/images/search?text=%D0%BC%D0%B0%D1%81%D1%82%D0%B5%D1%80%20%D0%B8%20%D0%BC%D0%B0%D1%80%D0%B3%D0%B0%D1%80%D0%B8%D1%82%D0%B0%20%D0%BA%D0%BD%D0%B8%D0%B3%D0%B0&from=tabbar&pos=1&img_url=http%3A%2F%2Fmam4.ru%2Fresize%2F1280x-%2Fhttps%2Fwww.mam4.ru%2Fmedia%2Fupload%2Fuser%2F10807%2Fff%2F1631437479291.jpg%3Fh%3D68QJBhpTmqP34bJHHh-6ig&rpt=simage&lr=157",
                       Description = "Мастер крут",
                       PageCount = 1130,
                       PublishDate = new DateTime(1966, 12, 03)

                   }
               );
        } // Books

        public static void SeedAuthors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(

                new Author
                {
                    AuthorId = 1,
                    FirstName = "Лев",
                    LastName = "Толстой",
                    MiddleName = "Николаевич"
                },

                new Author
                {
                    AuthorId = 2,
                    FirstName = "Антон",
                    LastName = "Чехов",
                    MiddleName = "Павлович"
                },

                new Author
                {
                    AuthorId = 3,
                    FirstName = "Джефри",
                    LastName = "Рихтер",
                    MiddleName = null
                },

                new Author
                {
                    AuthorId = 4,
                    FirstName = "Михаил",
                    LastName = "Булгаков",
                    MiddleName = "Афанасьевич"
                }
            );
        }  // Authors

        public static void SeedAuthorsBook(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorsBook>().HasData(
                    new AuthorsBook
                    {
                        AuthorsBooksId = 1,
                        AuthorId = 1,
                        BookId = 1
                    },

                    new AuthorsBook
                    {
                        AuthorsBooksId = 2,
                        AuthorId = 2,
                        BookId = 2
                    },

                    new AuthorsBook
                    {
                        AuthorsBooksId = 3,
                        AuthorId = 3,
                        BookId = 3
                    },

                    new AuthorsBook
                    {
                        AuthorsBooksId = 4,
                        AuthorId = 4,
                        BookId = 4
                    }

                );
        } // AuthorsBook

        public static void SeedGenre(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(

                new Genre
                {
                    GenreId = 1,
                    Type = "Любовный роман"
                },

                new Genre
                {
                    GenreId = 2,
                    Type = "Модернизм в литературе"
                },

                new Genre
                {
                    GenreId = 3,
                    Type = "Техническая литература"
                },

                new Genre
                {
                    GenreId = 4,
                    Type = "роман"
                },

                new Genre
                {
                    GenreId = 5,
                    Type = "рассказ"
                }
             );
        }// Genre

        public static void SeedBooksGenre(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BooksGenre>().HasData(

                new BooksGenre
                {
                    BooksGenresId = 1,
                    BookId = 1,
                    GenreId = 4
                },
                new BooksGenre
                {
                    BooksGenresId = 2,
                    BookId = 2,
                    GenreId = 5
                },
                new BooksGenre
                {
                    BooksGenresId = 3,
                    BookId = 4,
                    GenreId = 1
                },
                new BooksGenre
                {
                    BooksGenresId = 4,
                    BookId = 4,
                    GenreId = 2
                }

            );
        }// BooksGenre

        public static void SeedLibraries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Library>().HasData(

                new Library
                {
                    LibraryId = 1,
                    Name = "Национальная библиотека Минска",
                    Address = "просп.Независимости, 11б",
                    PhoneNumber = "+375 17 368-37-37",
                    Email = "www.nlb.by",
                    ChartLink = "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48",
                    ShortDiscription = "Национальная библиотека Беларуси (НББ)",
                    CoverImage = "https://www.belarus.by/dadvimages/001339_318669.jpg",
                    DirectorPhotoLink = "https://www.belarus.by/dadvimages/001339_318669.jpg",
                    AgeGroup = "Нет ограничений ",
                    HistoryOfLibrary = "Национальная библиотека Беларуси (НББ) была основана постановлением Совета народных комиссаров БССР в 1922 году как Белорусская государственная и университетская библиотека Белорусского государственного университета (БГУ). На момент открытия фонды библиотеки насчитывали всего 60 тысяч экземпляров, которыми пользовались 1,1 тысячи человек. Первым собственным зданием библиотеки стал Юбилейный дом на Захарьевской улице (ныне — проспект Независимости). Постановлением СНК БССР от 14 мая 1926 году библиотека была выведена из состава БГУ и реорганизована в Белорусскую государственную библиотеку. В 1932 году библиотеке было присвоено имя В. И. Ленина. В тот же год библиотека получила новое здание архитектора Г. Лаврова в конструктивистском стиле. ",

                },
                 new Library
                 {
                     LibraryId = 2,
                     Name = "Библиотека им. Янки Купалы",
                     Address = "Улица Веры Хоружей 16",
                     PhoneNumber = "8 017 242-21-15",
                     Email = "www.publib.by/",
                     ChartLink = "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48",
                     ShortDiscription = "Цэнтральная бібліятэка імя Янкі Купалы",
                     CoverImage = "https://publib.by/wp-content/uploads/2022/06/czentralnaya-biblioteka-imeni-yanki-kupaly-1.jpg",
                     DirectorPhotoLink = "https://publib.by/wp-content/uploads/2022/06/czentralnaya-biblioteka-imeni-yanki-kupaly-1.jpg",
                     AgeGroup = "Нет ограничений",
                     HistoryOfLibrary = "Сёння Цэнтральная бібліятэка імя Янкі Купалы – гэта: ТРАДЫЦЫЯ БЫЦЬ ПАТРЭБНАЙ",
                 }
                );
        } // Library

        public static void SeedImagesFourCorusel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImagesFourCorusel>().HasData(

                    new ImagesFourCorusel
                    {
                        ImagesFourCoruselId = 1,
                        Link = "https://nashaniva.com/photos/generated/fb249647.png",
                        LibraryId = 1
                    },
                    new ImagesFourCorusel
                    {
                        ImagesFourCoruselId = 2,
                        Link = "http://knigoplaneta.ru/wp-content/uploads/2015/05/DSC_0253.jpg",
                        LibraryId = 1
                    },
                    new ImagesFourCorusel
                    {
                        ImagesFourCoruselId = 3,
                        Link = "http://s4.fotokto.ru/photo/full/492/4927138.jpg",
                        LibraryId = 1
                    }
                );
        } // ImagesFourCorusel

        public static void SeedOperatingModes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperatingModes>().HasData(

                    new OperatingModes
                    {
                        OperatingModeId = 1,
                        StartWork = "8:00",
                        EndWork = "20:00",
                        CleanUpDay = "Понедельник",
                        LibraryId = 1
                    },

                    new OperatingModes
                    {
                        OperatingModeId = 2,
                        StartWork = "10:00",
                        EndWork = "22:00",
                        CleanUpDay = "Пятница",
                        LibraryId = 1
                    },

                    new OperatingModes
                    {
                        OperatingModeId = 3,
                        StartWork = "10:00",
                        EndWork = "22:00",
                        CleanUpDay = "Среда",
                        LibraryId = 1
                    }
                );
        }  // OperatingModes

        public static void SeedBooksLibrary(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BooksLibrary>().HasData(
                 new BooksLibrary
                 {
                     BooksLibrariesId = 1,
                     BookId = 1,
                     LibraryId = 1,
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 2,
                     BookId = 2,
                     LibraryId = 1,
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 3,
                     BookId = 3,
                     LibraryId = 1,
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 4,
                     BookId = 4,
                     LibraryId = 1,
                 }
                );
        }
    }
}
