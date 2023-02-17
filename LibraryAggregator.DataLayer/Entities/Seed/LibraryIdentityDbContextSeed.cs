using LibraryAggregator.DataLayer.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace LibraryAggregator.DataLayer.Entities.Seed
{
    public class LibraryIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser()
                {
                    DisplayName = "user",
                    Email = "user@user.com",
                    UserName = "user@user.com",
                    Address = new Address()
                    {
                        FirstName = "user",
                        LastName = "user",
                        Street = "Zavodskaya",
                        City = "Minsk"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
