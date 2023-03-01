using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAggregator.DataLayer.Entities
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<Booking> Booking { get; set; }
    }
}
