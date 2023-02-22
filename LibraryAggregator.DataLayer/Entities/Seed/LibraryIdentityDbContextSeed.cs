using LibraryAggregator.DataLayer.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace LibraryAggregator.DataLayer.Entities.Seed
{
    public class LibraryIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Bob",
                    Email = "bob@test.com",
                    UserName = "bob@test.com",
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
