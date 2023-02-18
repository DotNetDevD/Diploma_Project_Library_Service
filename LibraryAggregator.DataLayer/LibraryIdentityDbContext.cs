using LibraryAggregator.DataLayer.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer
{
    public class LibraryIdentityDbContext : IdentityDbContext<AppUser>
    {
        public LibraryIdentityDbContext(DbContextOptions<LibraryIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRole(builder);
            SeedUser(builder);
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                new IdentityRole { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole { Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" }
                );
        }
        public void SeedUser(ModelBuilder builder)
        {
            var user = new AppUser()
            {
                DisplayName = "user",
                Email = "user@user.com",
                UserName = "user@user.com",
            };
            builder.Entity<AppUser>().HasData(user);
        }
    }
}
