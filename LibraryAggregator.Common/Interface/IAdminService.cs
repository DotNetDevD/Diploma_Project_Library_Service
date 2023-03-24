using LibraryAggregator.Common.Dtos;
using LibraryAggregator.DataLayer.Entities;
namespace LibraryAggregator.Common.Interface;
public interface IAdminService
{
  Task<TokenDto> AdminAuth(RequestLogin request);
  Task<Admin> GetAdminById(int id);
  Task<TokenDto> Refresh(TokenDto tokenDto);
}
