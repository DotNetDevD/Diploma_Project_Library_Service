using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.Common.Interface;

namespace LibraryAggregator.API.Controllers
{
    public class SearchController : ApiBaseController
    {
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }
        [HttpGet("{title}")]
        public Task<IEnumerable<Book>> SearchBooks(string title)
        {
            return _searchService.GetSomeBooks(title);
        }

      
    }
}
