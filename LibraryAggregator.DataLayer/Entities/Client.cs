namespace LibraryAggregator.DataLayer.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Booking Booking { get; set; }
    }
}
