using FullStack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
            Database.EnsureCreated(); 
        }

        DbSet<Test> Tests { get; set; }
    }
}
