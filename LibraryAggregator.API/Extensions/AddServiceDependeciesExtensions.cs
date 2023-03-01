using LibraryAggregator.Common.Interface;
using LibraryAggregator.Common.Implementation;

namespace LibraryAggregator.API.Extensions
{
    public static class AddServiceDependeciesExtensions
    {
        public static void AddServicesDependecies(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<ILibraryService, LibraryService>();
            services.AddScoped<IUrlProviderService, UrlProviderService>();
            services.AddScoped<ISearchService, SearchService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IStateService, StateService>();
            services.AddScoped<IClientService, ClientService>();
        }
    }
}
