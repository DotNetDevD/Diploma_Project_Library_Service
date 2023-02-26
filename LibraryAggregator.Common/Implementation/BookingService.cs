﻿using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IBooksLibraryRepository _booksLibraryRepository;
        public BookingService(IBookingRepository bookingRepository, IBooksLibraryRepository booksLibraryRepository)
        {
            _bookingRepository = bookingRepository;
            _booksLibraryRepository = booksLibraryRepository;
        }

        public async Task CreateBookingAsync(Booking booking)
        {
            var difBookingTime = booking.FinishDate - booking.StartDate;
            if (difBookingTime.Days > 21)
            {
                booking.FinishDate = booking.StartDate.AddDays(21);
            }

            await _bookingRepository.CreateAsync(booking);
        }

        public async Task DeleteBookingAsync(int id)
        {
            await _bookingRepository.DeleteAsync(id);
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

        public async Task<IEnumerable<Booking>> GetBookingListAsync()
        {
            return await _bookingRepository.GetFullInfoBookingsAsync();
        }

        //TODO: correct update Method
        public async Task UpdateBookingAsync(int id)
        {
            await _bookingRepository.UpdateAsync(id);
        }
    }
}
