using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.Common.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SearchController : ApiBaseController
    {
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("{title}")]
        public async Task<IEnumerable<Book>> SearchListBookByTitle(string title)
        {
            return await _searchService.SearchBooksByTitle(title);
        }

        [ActionName("SearchAuthors")]
        [HttpGet("{fullName}")]
        public async Task<IEnumerable<Author>> SearchAuthorsByFullName(string fullName)
        {
            return await _searchService.SearchAuthorsByFullName(fullName);
        }
    }
}
