using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IBooksLibraryRepository _booksLibraryRepository;
        private readonly IClientRepository _clientRepository;
        public BookingService(IBookingRepository bookingRepository, IBooksLibraryRepository booksLibraryRepository, 
            IClientRepository clientRepository)
        {
            _bookingRepository = bookingRepository;
            _booksLibraryRepository = booksLibraryRepository;
            _clientRepository = clientRepository;
        }

        public async Task CreateBookingAsync(BookingDto bookingDto)
        {
            await CreateClient(bookingDto);

            Random random = new Random();
            Booking booking = new()
            {
                Code = random.Next(1, 10000),
                StartDate = DateTime.Now,
                FinishDate = DateTime.Now.AddDays(14),
                BooksLibraryId = bookingDto.BookLibraryId,
                ClientId = await _clientRepository.GetClientIdByEmailAsync(bookingDto.Email),
                //TODO: code enum change 
                BookingStatusId = 2
            };

            await _bookingRepository.CreateAsync(booking);
        }

        private async Task CreateClient(BookingDto bookingDto)
        {
            Client client = new()
            {
                Name = bookingDto.Name,
                Surname = bookingDto.Surname,
                PhoneNumber = bookingDto.PhoneNumber,
                Email = bookingDto.Email
            };
            await _clientRepository.CreateAsync(client);
        }

        public async Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id)
        {
            IEnumerable<BooksLibrary> booksLibraries = await _booksLibraryRepository.GetdLibraryListByBookIdAsync(id);
            foreach (BooksLibrary book in booksLibraries)
            {
                //TODO: magic number!!! => enum
                book.BookedBook = book.Booking.Where(b => b.BookingStatusId == 2).Count();
                book.FreeBook = book.Count - book.BookedBook;
                if (book.FreeBook > 0)
                    book.IsFreeBook = false;
            }
            return booksLibraries;
        }

        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _bookingRepository.GetFullInfoBookingAsync(id);
        }

        public async Task<BooksLibrary> GetFullBookLibraryInfoById(int id)
        {
            return await _booksLibraryRepository.GetFullBookLibraryInfoById(id);
        }
    }
}
