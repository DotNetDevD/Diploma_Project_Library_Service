using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities
{
    public class ImagesForCarousel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImagesForCarouselId { get; set; }
        public string? Link { get; set; }
        public int? LibraryId { get; set; }
        public Library? Library { get; set; }
    }
}

        