using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.AdminAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AdminController : Controller
  {
    private readonly IAdminService _adminService;

    public AdminController(IAdminService adminService)
    {
      _adminService = adminService;
    }
    [Authorize]
    [HttpGet("{id}")]
    public async Task<Admin> GetAdmin(int id)
    {
      return await _adminService.GetAdminById(id);
    }
    [HttpPost("refresh")]
    public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
    {
      return  await _adminService.Refresh(tokenDto);
    }
  }
}
