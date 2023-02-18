using LibraryAggregator.DataLayer.Entities.Identity;

namespace LibraryAggregator.Common.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
