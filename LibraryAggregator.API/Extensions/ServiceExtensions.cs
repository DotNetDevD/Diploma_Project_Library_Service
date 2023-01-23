using LibraryAggregator.DataLayer.Repository.IRepository;
using LibraryAggregator.DataLayer.Repository;

namespace LibraryAggregator.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
