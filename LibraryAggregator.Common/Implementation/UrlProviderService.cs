using LibraryAggregator.Common.Interface;
using Microsoft.Extensions.Configuration;

namespace LibraryAggregator.Common.Implementation
{
    public class UrlProviderService : IUrlProviderService
    {
        private readonly IConfiguration _configuration;
        public UrlProviderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string? ConcatHostUrl(string host)
        {
            var imageStorageHost = _configuration["ImageStorageHost"];
            return $"{imageStorageHost}{host}";
        }
    }
}
