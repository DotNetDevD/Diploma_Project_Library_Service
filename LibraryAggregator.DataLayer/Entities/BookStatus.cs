namespace LibraryAggregator.DataLayer.Entities
{
    public class BookStatus
    {
        public int BookStatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public string? StatusDescription { get; set; }
        public ICollection<Booking> Booking { get; set; }
    }
}
