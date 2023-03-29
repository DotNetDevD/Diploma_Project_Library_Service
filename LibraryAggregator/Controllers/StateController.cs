using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LibraryAggregator.AdminAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateController : Controller
  {
    private readonly IStateService _stateService;

    public StateController(IStateService stateService)
    {
       _stateService = stateService;
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
