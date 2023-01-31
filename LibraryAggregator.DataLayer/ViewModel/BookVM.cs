namespace LibraryAggregator.DataLayer.ViewModel
{
    public class BookVM
    {
        public string Isbn { get; set; } = null!;

        public string Title { get; set; } = null!;

        public DateTime? PublishDate { get; set; }

        public string AuthorFullName { get; set; } = null!;

        public string GenreType { get; set; } = null!;

        public int PageCount { get; set; }
    }
}
