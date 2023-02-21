using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.Common.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    public class SearchController : ApiBaseController
    {
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("book/{title}")]
        public async Task<IEnumerable<Book>> SearchListBookByTitle(string title)
        {
            return await _searchService.SearchBooksByTitle(title);
        }

        [HttpGet("author/{fullName}")]
        public async Task<IEnumerable<Author>> SearchAuthorsByFullName(string fullName)
        {
            return await _searchService.SearchAuthorsByFullName(fullName);
        }

        [HttpGet("library/{name}")]
        public async Task<IEnumerable<Library>> SearchLibraryByName(string name)
        {
            return await _searchService.SearchLibrariesByName(name);
        }
    }
}
