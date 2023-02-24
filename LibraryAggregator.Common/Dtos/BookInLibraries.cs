namespace LibraryAggregator.Common.Dtos
{
    public class BookInLibraries
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public string Isbn { get; set; } = null!;
        public int LibraryId { get; set; }
        public string? LibraryName { get; set; }
        public string? Address { get; set; }
        public int TotalCount { get; set; }
        public int FreeCount { get; set; }
        public int BookingCount { get; set; }
    }
}
