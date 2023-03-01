using LibraryAggregator.DataLayer.Entities.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAggregator.DataLayer.Entities
{
    public class Booking
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }
        public int Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int BooksLibraryId { get; set; }
        public BooksLibrary? BooksLibrary { get; set; }
        public int ClientId { get; set; }
        public virtual Client? Client { get; set; }
        public BookingStatuses BookingStatus
        {
            get; set;
        }
    }
}
