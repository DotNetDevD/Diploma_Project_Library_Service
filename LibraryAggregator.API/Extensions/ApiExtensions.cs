using LibraryAggregator.DataLayer.Repository.IRepository;
using LibraryAggregator.DataLayer.Repository;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.Common.Implementation;

namespace LibraryAggregator.API.Extensions
{
    public static class ApiExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
        }
        public static void ConfigureServiceWrapper(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IGenreService, GenreService>();
        }
    }
}
