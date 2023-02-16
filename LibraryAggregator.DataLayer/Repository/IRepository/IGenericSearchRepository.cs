namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface  IGenericSearchRepository <T>
        where T : class
    {
        Task<IEnumerable<T>> SearchSomeEntityByTitle(string title);
    }
}
