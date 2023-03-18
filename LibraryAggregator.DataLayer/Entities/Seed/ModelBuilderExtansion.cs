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
               Description = "Повесть Л. Н. Толстого, над которой он работал с 1882 по 1886 год, внПовесть широко признана одной из вершин мировой литературы[1] и величайшим свершением Толстого в области малой литературной формы.Входит во Всемирную библиотеку(серия книг Норвежского книжного клуба)",
               PageCount = 543,
               PublishDate = new DateTime(1886, 10, 12)
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
            MapLink = "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48",
            ShortDiscription = "Национальная библиотека Беларуси (НББ)",
            CoverImgPath = "Assets/Images/Libraries/natsionalnaya_biblioteka.jpg",
            DirectorPhotoLink = "Assets/Images/Libraries/natsionalnaya_biblioteka.jpg",
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
             MapLink = "https://yandex.by/maps/org/natsionalnaya_biblioteka_belarusi/1087338903/?ll=27.647557%2C53.930867&z=16.48",
             ShortDiscription = "Цэнтральная бібліятэка імя Янкі Купалы",
             CoverImgPath = "Assets/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg",
             DirectorPhotoLink = "Assets/Images/Libraries/czentralnaya-biblioteka-imeni-yanki-kupaly.jpg",
             AgeGroup = "Нет ограничений",
             HistoryOfLibrary = "Сёння Цэнтральная бібліятэка імя Янкі Купалы – гэта: ТРАДЫЦЫЯ БЫЦЬ ПАТРЭБНАЙ",
           }
          );
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
                CoverImgPath = "Assets/Images/Libraries/Carousel/imeni-yanki-kupaly-3.jpg",
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
    public static void SeedAdmin(this ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Admin>().HasData(
        new Admin
        {
          AdminId = 1,
          Login = "National",
          Password = "4FCBFF10B8CC9DCD5FB2D3B5D5C186C2",
          Message = "Admin",
          LibraryId = 1

        }
        ); 
    }
  }
}
