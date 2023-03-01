﻿using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Enum;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    public class BookingController : ApiBaseController
    {
        private readonly IBookingService _bookingService;
        private readonly IStateService _stateService;

        public BookingController(IBookingService bookingService, IStateService stateService)
        {
            _bookingService = bookingService;
            _stateService = stateService;
        }

        [HttpGet("bookLibrary/{id}")]
        public async Task<BooksLibrary> GetFullBookLibraryInfoById(int id)
        {
            return await _bookingService.GetFullBookLibraryInfoById(id);
        }

        [HttpGet("book/{id}")]
        public async Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id)
        {
            return await _bookingService.GetAvailableBookingByBookIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(BookingDto bookingDto)
        {
            await _bookingService.CreateBookingAsync(bookingDto);
        }


        [HttpPut("booking/{bookingStatus}")]
        public async Task ChangeStatusBooking(int id, BookingStatuses bookingStatus)
        {
            await _stateService.BookingAsync(id, bookingStatus);
        }

        [HttpPut("returnedclient/{bookingStatus}")]
        public async Task ChangeStatusReturnedClient(int id, BookingStatuses bookingStatus)
        {
            await _stateService.ReturnedClientAsync(id, bookingStatus);
        }

        [HttpPut("giventotheclient/{bookingStatus}")]
        public async Task ChangeStatusGivenToTheClient(int id, BookingStatuses bookingStatus)
        {
            await _stateService.GivenToTheClientAsync(id, bookingStatus);
        }

        [HttpPut("cancell/{bookingStatus}")]
        public async Task ChangeStatusCancell(int id, BookingStatuses bookingStatus)
        {
            await _stateService.CancellAsync(id, bookingStatus);
        }

    }
}
