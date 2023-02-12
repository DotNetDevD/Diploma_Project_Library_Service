using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface ISearchService
    {
        public Task<IEnumerable<Book>> GetSomeBooks(string title);
    }
}
