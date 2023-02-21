using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface ISearchService
    {
        Task<IEnumerable<Author>> SearchAuthorsByFullName(string fullname);
        Task<IEnumerable<Book>> SearchBooksByTitle(string title);
        Task<IEnumerable<Genre>> SearchGenreByType(string type);
        Task<IEnumerable<Library>> SearchLibrariesByName(string name);
        Task<SearchBookLibraryAuthor> SearchBookLibraryAuthorByInput(string input);
    }
}
