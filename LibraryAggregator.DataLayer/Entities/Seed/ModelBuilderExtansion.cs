using LibraryAggregator.DataLayer.Entities.Enum;
using Microsoft.EntityFrameworkCore;

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
                    Isbn = "978-5-9268-2544-1",
                    CoverImgPath = "Assets/Images/Books/Anna_Karenina.jpg",
                    Description = "Роман Льва Толстого о трагической любви замужней дамы Анны Карениной и \r\nблестящего офицера Алексея Вронского на фоне счастливой семейной жизни дворян Константина Лёвина\r\n и Кити Щербацкой. Масштабная картина нравов и быта дворянской среды Петербурга и Москвы второй половины XIX века, \r\nсочетающая философские размышления авторского alter ego Лёвина с передовыми в русской литературе психологическими зарисовками, а также сценами из жизни крестьян.",
                    PageCount = 1130,
                    PublishDate = new DateTime(1877, 04, 17)
                },

                 new Book
                 {
                     BookId = 2,
                     Title = "Человек в футляре",
                     Isbn = "978-5-389-16173-2",
                     CoverImgPath = "Assets/Images/Books/TheManInTheCase.jpg",
                     Description = "Серия «Маленькая трилогия», состоящая из трёх рассказов — «Человек в футляре», \r\n«Крыжовник», «О любви» — не должна была оканчиваться рассказом «О любви». \r\nВо время написания рассказов произошёл спад активности творчества, а позднее Чехова отвлекло заболевание туберкулезом.\r\nНад рассказом Чехов работал в мае — июне 1898 года в Мелихове. В начале июня 1898 года рассказ готовился к печати, а 15 июня 1898 года рукопись была отправлена в ж",
                     PageCount = 960,
                     PublishDate = new DateTime(1898, 06, 15)
                 },

                  new Book
                  {
                      BookId = 3,
                      Title = "CLR via C#",
                      Isbn = "978-5-7502-0348-1",
                      CoverImgPath = "Assets/Images/Books/CLR-via-C.jpg",
                      Description = "Эта книга, выходящая в третьем издании и уже ставшая классическим учебником по программированию,\r\n подробно описывает внутреннее устройство и функционирование общеязыковой исполняющей среды (CLR) Microsoft .NET Framework версии 4.0. \r\nНаписанная признанным экспертом в области программирования Джеффри Рихтером, много лет являющимся консультантом команды разработчиков .NET Framework компании Microsoft, \r\nкнига научит вас создавать по-настоящему надежные приложения любого вида, в том числе с использованием Microsoft Silverlight, ASP.NET, Windows Presentation Foundation и т.д.\r\nТретье издание полностью обновлено в соответствии со спецификацией платформы .NET Framework 4.0 и принципами многоядерного программирования.",
                      PageCount = 896,
                      PublishDate = new DateTime(2008, 02, 11)
                  },

                   new Book
                   {
                       BookId = 4,
                       Title = "Мастер и Маргарита",
                       Isbn = "978-5-04-102789-1",
                       CoverImgPath = "Assets/Images/Books/The%20master%20and%20margarita.jpg",
                       Description = "«Ма́стер и Маргари́та» — роман Михаила Афанасьевича Булгакова, работа над которым началась в декабре 1928 года и продолжалась вплоть до смерти писателя в марте 1940 года.\r\n Роман относится к незавершённым произведениям; редактирование и сведение воедино черновых записей осуществляла после смерти мужа вдова писателя — Елена Сергеевна. \r\nПервая версия романа, имевшая названия «Копыто инженера», «Чёрный маг» и другие, была уничтожена Булгаковым в 1930 году. \r\nВ последующих редакциях среди героев произведения появились автор романа о Понтии Пилате и его возлюбленная. Окончательное название — «Мастер и Маргарита» — оформилось в 1937 году.\r\n\r\nПервая публикация произведения в сокращённом виде была осуществлена в 1966—1967 годах (журнал «Москва», предисловие Константина Симонова, послесловие Абрама Вулиса). \r\nПервое полное издание книги на русском языке вышло в 1967 году (издательство «YMCA-Press», Париж).\r\n В СССР книжный вариант без купюр увидел свет в 1973 году (издательство «Художественная литература», тираж 30 000 экземпляров). \r\nПроизведение неоднократно экранизировано и инсценировано.",
                       PageCount = 1130,
                       PublishDate = new DateTime(1966, 12, 03)
                   },

                   new Book
                   {
                       BookId = 5,
                       Title = "Смерть Ивана Ильича",
                       Isbn = "978-5-699-15152-2",
                       CoverImgPath = "Assets/Images/Books/The%20death%20of%20Ivan%20Ilyich.jpeg",
                       Description = "Повесть Л. Н. Толстого, над которой он работал с 1882 по 1886 год. Повесть широко признана одной из вершин мировой литературы и величайшим свершением Толстого в области малой литературной формы.Входит во Всемирную библиотеку (серия книг Норвежского книжного клуба)",
                       PageCount = 543,
                       PublishDate = new DateTime(1886, 10, 12)
                   },

                   new Book
                   {
                       BookId = 6,
                       Title = "Чистый код",
                       Isbn = "978-5-4461-0960-9",
                       CoverImgPath = "Assets/Images/Books/clean-code.jpg",
                       Description = "Плохой код может работать, но он будет мешать развитию проекта и компании-разработчика, требуя дополнительные ресурсы на поддержку и \"укрощение\". Каким же должен быть код? Эта книга полна реальных примеров, позволяющих взглянуть на код с различных направлений: сверху вниз, снизу вверх и даже изнутри. Вы узнаете много нового о коде.",
                       PageCount = 464,
                       PublishDate = new DateTime(2021, 10, 12)
                   },

                   new Book
                   {
                       BookId = 7,
                       Title = "Чистая архитектура",
                       Isbn = "978-5-4461-0772-8",
                       CoverImgPath = "Assets/Images/Books/clean-architecture.jpg",
                       Description = "Всех программистов, которые добиваются успеха в мире разработки ПО, отличает один общий признак: они больше всего заботятся о качестве создаваемого программного обеспечения. Это – основа для них. Потому что они являются профессионалами своего дела.",
                       PageCount = 352,
                       PublishDate = new DateTime(2020, 10, 11)
                   },

                   new Book
                   {
                       BookId = 8,
                       Title = "Совершенный код",
                       Isbn = "978-5-9909805-1-8",
                       CoverImgPath = "Assets/Images/Books/code-complete.jpg",
                       Description = "Более 10 лет первое издание этой книги считалось одним из лучших практических руководств по программированию. Сейчас эта книга полностью обновлена с учетом современных тенденций и технологий и дополнена сотнями новых примеров, иллюстрирующих искусство и науку программирования.",
                       PageCount = 896,
                       PublishDate = new DateTime(2019, 11, 12)
                   },

                   new Book
                   {
                       BookId = 9,
                       Title = "Затерянный мир",
                       Isbn = "978-5-04-160964-1",
                       CoverImgPath = "Assets/Images/Books/Lost-World.jpg",
                       Description = "\"Затерянный мир\" – захватывающий научно-фантастический роман английского писателя Артура Конан Дойла. Гениальный и известный своей эксцентричностью профессор Челленджер заявляет, что во время путешествия по Южной Америке обнаружил район, где до сих пор сохранились доисторические формы жизни.",
                       PageCount = 320,
                       PublishDate = new DateTime(2023, 11, 12)
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
                    MiddleName = "Николаевич",
                    DateOfBirth = new DateTime(1828, 09, 9),
                    CoverImgPath = "Assets/Images/Authors/lev-tolstoy.jpg",
                    Biography = "Один из наиболее широко известных русских писателей и мыслителей, почитаемый как один из величайших писателей мира. Участник обороны Севастополя. Просветитель, публицист, религиозный мыслитель, чьё авторитетное мнение послужило причиной возникновения нового религиозно-нравственного течения — толстовства. Член-корреспондент Императорской Академии наук (1873), почётный академик по разряду изящной словесности (1900)."
                },

                new Author
                {
                    AuthorId = 2,
                    FirstName = "Антон",
                    LastName = "Чехов",
                    MiddleName = "Павлович",
                    DateOfBirth = new DateTime(1860, 01, 29),
                    CoverImgPath = "Assets/Images/Authors/anton-chekhov.jpg",
                    Biography = "Антон Павлович Чехов родился в Таганроге. Обучался в греческой школе, затем в классической гимназии. В 1876 году отец Чехова разорился и был вынужден бежать в Москву, а Антон Павлович остался в Таганроге. Свои первые литературные работы Чехов под разными псевдонимами посылает в столичные журналы; среди его первых произведений не сохранившиеся комедии \"Нашла коса на камень\" и \"Недаром курица пела\", в так же солидная драма \"Безотцовщина\"."
                },

                new Author
                {
                    AuthorId = 3,
                    FirstName = "Джефри",
                    LastName = "Рихтер",
                    MiddleName = null,
                    DateOfBirth = new DateTime(1964, 07, 27),
                    Biography = "Джеффри Рихтер – программист, автор самых известных книг о Win32 и .NET. Рихтер – один из учредителей компании Wintellect, занимающейся подготовкой IT-специалистов и предоставлением консалтинговых услуг фирмам-разработчикам ПО. Рихтер работал с такими компаниями как Intel, DreamWorks и Microsoft.",
                    CoverImgPath = "Assets/Images/Authors/dzheffri-rihter.jpg",
                },

                new Author
                {
                    AuthorId = 4,
                    FirstName = "Михаил",
                    LastName = "Булгаков",
                    MiddleName = "Афанасьевич",
                    DateOfBirth = new DateTime(1891, 05, 03),
                    Biography = "Учился в Первой Киевской гимназии, позднее — на медицинском факультете Киевского университета. Первую пробу пера совершил в семилетнем возрасте, написав рассказ «Похождения Светланы».",
                    CoverImgPath = "Assets/Images/Authors/mikhail-bulgakov.jpg"
                },

                 new Author
                 {
                     AuthorId = 5,
                     FirstName = "Роберт",
                     LastName = "Мартин",
                     DateOfBirth = new DateTime(1952, 04, 04),
                     Biography = "Роберт Мартин — профессиональный разработчик ПО, международный консультант, автор книг по программированию. Известен также под псевдонимом Дядюшка Боб.",
                     CoverImgPath = "Assets/Images/Authors/robert-matrin.jpg"
                 },

                 new Author
                 {
                     AuthorId = 6,
                     FirstName = "Стив",
                     LastName = "МакКоннел",
                     DateOfBirth = new DateTime(1952, 04, 04),
                     Biography = "Стив Макконнелл — американский программист, автор нескольких книгпо разработке ПО, в том числе бестселера \"Совершенный код\"",
                     CoverImgPath = "Assets/Images/Authors/McConnell.jpg"
                 },

                 new Author
                 {
                     AuthorId = 7,
                     FirstName = "Артур",
                     MiddleName = "Конан",
                     LastName = "Дойл",
                     DateOfBirth = new DateTime(1859, 05, 22),
                     Biography = "Английский писатель (по образованию врач), автор многочисленных приключенческих, исторических, публицистических, фантастических и юмористических произведений. Создатель классических персонажей детективной, научно-фантастической и историко-приключенческой литературы — гениального сыщика Шерлока Холмса",
                     CoverImgPath = "Assets/Images/Authors/Conan-Doyle.jpg"
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
                    },

                    new AuthorsBook
                    {
                        AuthorsBooksId = 5,
                        AuthorId = 1,
                        BookId = 5
                    },

                    new AuthorsBook
                    {
                        AuthorsBooksId = 6,
                        AuthorId = 5,
                        BookId = 6
                    },

                    new AuthorsBook
                    {
                        AuthorsBooksId = 7,
                        AuthorId = 5,
                        BookId = 7
                    },

                    new AuthorsBook
                    {
                        AuthorsBooksId = 8,
                        AuthorId = 6,
                        BookId = 8
                    },

                    new AuthorsBook
                    {
                        AuthorsBooksId = 9,
                        AuthorId = 7,
                        BookId = 9
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
                    Type = "Роман"
                },

                new Genre
                {
                    GenreId = 5,
                    Type = "Рассказ"
                },

                new Genre
                {
                    GenreId = 6,
                    Type = "Детектив"
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
                },

                new BooksGenre
                {
                    BooksGenresId = 5,
                    BookId = 3,
                    GenreId = 3
                },

                new BooksGenre
                {
                    BooksGenresId = 6,
                    BookId = 5,
                    GenreId = 6
                },

                new BooksGenre
                {
                    BooksGenresId = 7,
                    BookId = 6,
                    GenreId = 3
                },

                new BooksGenre
                {
                    BooksGenresId = 8,
                    BookId = 7,
                    GenreId = 3
                },

                new BooksGenre
                {
                    BooksGenresId = 9,
                    BookId = 8,
                    GenreId = 3
                },

                new BooksGenre
                {
                    BooksGenresId = 10,
                    BookId = 4,
                    GenreId = 6
                },

                new BooksGenre
                {
                    BooksGenresId = 11,
                    BookId = 9,
                    GenreId = 6
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
                    Site = "https://www.nlb.by",
                    MapLink = "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48",
                    ShortDiscription = "Национальная библиотека Беларуси (НББ)",
                    CoverImgPath = "Assets/Images/Libraries/natsionalnaya_biblioteka.jpg",
                    DirectorPhotoLink = "Assets/Images/Libraries/natsionalnaya_biblioteka.jpg",
                    AgeGroup = "Нет ограничений ",
                    HistoryOfLibrary = "Национальная библиотека Беларуси (НББ) была основана постановлением Совета народных комиссаров БССР в 1922 году как Белорусская государственная и университетская библиотека Белорусского государственного университета (БГУ). На момент открытия фонды библиотеки насчитывали всего 60 тысяч экземпляров, которыми пользовались 1,1 тысячи человек. Первым собственным зданием библиотеки стал Юбилейный дом на Захарьевской улице (ныне — проспект Независимости). Постановлением СНК БССР от 14 мая 1926 году библиотека была выведена из состава БГУ и реорганизована в Белорусскую государственную библиотеку. В 1932 году библиотеке было присвоено имя В. И. Ленина. В тот же год библиотека получила новое здание архитектора Г. Лаврова в конструктивистском стиле. ",
                    Transport = "Автобус: 113С, 27, 87С, 91. Поезд : МІНСК - ЧЫРВОНЫ СЦЯГ. Троллейбус: 41, 61"
                },

                 new Library
                 {
                     LibraryId = 2,
                     Name = "Библиотека им. Янки Купалы",
                     Address = "Улица Веры Хоружей 16",
                     PhoneNumber = "8 017 242-21-15",
                     Site = "https://www.publib.by",
                     MapLink = "https://yandex.by/maps/org/tsentralnaya_biblioteka_imeni_yanki_kupaly/1048737828/?ll=27.570994%2C53.921319&z=16.67",
                     ShortDiscription = "Цэнтральная бібліятэка імя Янкі Купалы",
                     CoverImgPath = "Assets/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg",
                     DirectorPhotoLink = "Assets/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg",
                     AgeGroup = "Нет ограничений",
                     HistoryOfLibrary = "Вас приветствует Центральная библиотека имени Янки Купалы! Сегодня Центральная библиотека имени Янки Купалы - это: Одна из крупнейших библиотек города; На сайте библиотеки можно посмотреть ролик, сделанный к юбилею сотрудниками. Он рассказывает, что открылась библиотека 29 июля 1949 года, представляет на черно-белом снимке первое здание – Летнюю читальню парка имени М. Горького. Следующий адрес – ул. Карла Маркса, 8, сюда библиотека переехала в 1952-м. А на своем нынешнем месте прописалась в 1976-м. Первым директором стала Лидия Поградная, на снимке она – еще в солдатской шинели. В 1992 году библиотеке было присвоен награда Ленина. В тот же год библиотека получила новый ремонт от архитектора Г. Лазерева в конструктивистском стиле.",
                     Transport = "Автобус: 19, 24, 29, 59, 91. Троллейбус: 37 53",
                 }
                ); ;
        } // Library

        public static void SeedImagesFourCorusel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImagesForCarousel>().HasData(

                    new ImagesForCarousel
                    {
                        ImagesForCarouselId = 1,
                        CoverImgPath = "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-1.jpg",
                        LibraryId = 1
                    },

                    new ImagesForCarousel
                    {
                        ImagesForCarouselId = 2,
                        CoverImgPath = "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-2.jpg",
                        LibraryId = 1
                    },

                    new ImagesForCarousel
                    {
                        ImagesForCarouselId = 3,
                        CoverImgPath = "Assets/Images/Libraries/Carousel/natsionalnaya_biblioteka-3.jpg",
                        LibraryId = 1
                    },

                    new ImagesForCarousel
                    {
                        ImagesForCarouselId = 4,
                        CoverImgPath = "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-1.jpg",
                        LibraryId = 2
                    },

                    new ImagesForCarousel
                    {
                        ImagesForCarouselId = 5,
                        CoverImgPath = "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-2.jpg",
                        LibraryId = 2
                    },

                    new ImagesForCarousel
                    {
                        ImagesForCarouselId = 6,
                        CoverImgPath = "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-3.jpg",
                        LibraryId = 2
                    }
                );
        } // ImagesFourCorusel

        public static void SeedOperatingModes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperatingModes>().HasData(

                    new OperatingModes
                    {
                        OperatingModeId = 1,
                        Monday = "10:00–21:00",
                        Tuesday = "10:00–21:00",
                        Wednesday = "10:00–21:00",
                        Thursday = "10:00–21:00",
                        Friday = "10:00–21:00",
                        Saturday = "10:00–16:00",
                        Sunday = "10:00–16:00",
                        LibraryId = 1
                    },

                    new OperatingModes
                    {
                        OperatingModeId = 2,
                        Monday = "09:00–17:00",
                        Tuesday = "09:00–17:00",
                        Wednesday = "09:00–17:00",
                        Thursday = "09:00–17:00",
                        Friday = "09:00–17:00",
                        Saturday = "Выходной",
                        Sunday = "Выходной",
                        LibraryId = 2
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
                     BookedBook = 0,
                     IsFreeBook = true,
                     LibraryId = 1,
                     Count = 2
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 2,
                     BookId = 2,
                     LibraryId = 1,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 3
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 3,
                     BookId = 3,
                     LibraryId = 1,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 1
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 4,
                     BookId = 4,
                     LibraryId = 1,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 2
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 5,
                     BookId = 2,
                     LibraryId = 2,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 2
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 6,
                     BookId = 1,
                     LibraryId = 2,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 3
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 7,
                     BookId = 6,
                     LibraryId = 2,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 5
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 8,
                     BookId = 6,
                     LibraryId = 1,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 4
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 9,
                     BookId = 7,
                     LibraryId = 2,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 4
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 10,
                     BookId = 7,
                     LibraryId = 1,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 4
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 11,
                     BookId = 8,
                     LibraryId = 1,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 6
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 12,
                     BookId = 8,
                     LibraryId = 2,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 4
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 13,
                     BookId = 9,
                     LibraryId = 1,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 4
                 },

                 new BooksLibrary
                 {
                     BooksLibrariesId = 14,
                     BookId = 9,
                     LibraryId = 2,
                     BookedBook = 0,
                     IsFreeBook = true,
                     Count = 6
                 }

                );
        }
        public static void SeedClient(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                    new Client
                    {
                        ClientId = 1,
                        Name = "Артур",
                        Surname = "Пирожков",
                        Email = "test@test.com",
                        PhoneNumber = "+375299999999"
                    }
                );

            modelBuilder.Entity<Client>().HasData(
                   new Client
                   {
                       ClientId = 2,
                       Name = "Артур",
                       Surname = "Пирожков",
                       Email = "tes2t@com.by",
                       PhoneNumber = "+37529у9999999"
                   }
               );
        }
        public static void SeedBooking(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasData(
                    new Booking
                    {
                        BookingId = 1,
                        Code = 88889,
                        StartDate = new DateTime(2023, 1, 20),
                        FinishDate = new DateTime(2023, 2, 20),
                        BooksLibraryId = 1,
                        ClientId = 1,
                        BookingStatus = (BookingStatuses)2,
                    }
                );
        }
    }
}