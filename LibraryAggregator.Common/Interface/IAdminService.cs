using LibraryAggregator.DataLayer.Entities;
namespace LibraryAggregator.Common.Interface;
public interface IAdminService
{
  Task<Admin> AdminAuth(RequestLogin request);

}
