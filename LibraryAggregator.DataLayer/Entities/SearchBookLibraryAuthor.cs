namespace LibraryAggregator.DataLayer.Entities
{
    public class SearchBookLibraryAuthor
    {
        public IEnumerable<Book>? Books { get; set; } = new List<Book>();
        public IEnumerable<Author>? Authors { get; set; } = new List<Author>();
        public IEnumerable<Library>? Libraries { get; set; } = new List<Library>();
    }
}
