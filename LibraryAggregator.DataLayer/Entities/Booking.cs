namespace LibraryAggregator.DataLayer.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int BooksLibraryId { get; set; }
        public BooksLibrary? BooksLibrary { get; set; }
        public int ClientId { get; set; }
        public virtual Client? Client { get; set; }
        public int BookStatusId { get; set; }
        public virtual BookStatus? BookStatus { get; set; }
    }
}
