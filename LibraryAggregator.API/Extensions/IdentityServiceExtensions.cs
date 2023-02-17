using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace LibraryAggregator.API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<AppUser>();

            builder = new IdentityBuilder(builder.UserType, builder.Services);
            builder.AddEntityFrameworkStores<LibraryIdentityDbContext>();
            builder.AddSignInManager<SignInManager<AppUser>>();

            services.AddAuthentication();
            
            return services;
        }
    }
}
