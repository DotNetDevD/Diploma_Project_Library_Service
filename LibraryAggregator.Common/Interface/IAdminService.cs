using LibraryAggregator.Common.Dtos;
using LibraryAggregator.DataLayer.Entities;
namespace LibraryAggregator.Common.Interface;
public interface IAdminService
{
  Task<TokenDto> AdminAuth(RequestData request);
  Task<Admin> GetAdminById(int id);
  Task<TokenDto> Refresh(TokenDto tokenDto);
  Task<IEnumerable<LibraryDto>> GetListBooks(int id);
}
