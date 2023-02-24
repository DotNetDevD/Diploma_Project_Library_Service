namespace LibraryAggregator.DataLayer.Entities
{
    public class BookingStatus
    {
        public int BookingStatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public string? StatusDescription { get; set; }
        public ICollection<Booking> Booking { get; set; }
    }
}
