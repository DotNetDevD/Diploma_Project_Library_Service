using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.AdminAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AdminAuthController : Controller
  {
    private readonly IAdminService _adminService;

    public AdminAuthController(IAdminService adminService)
    {
      _adminService = adminService;
    }

    [HttpPost("authenticate")]
    public async Task<TokenDto> GetManager(RequestData request)
    {
      return await _adminService.AdminAuth(request);
    }
  }
}
