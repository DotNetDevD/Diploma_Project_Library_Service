using Microsoft.AspNetCore.Identity;

namespace LibraryAggregator.DataLayer.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }
}
