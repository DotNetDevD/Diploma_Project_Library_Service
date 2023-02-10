using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities
{
    public class ImagesForCarousel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImagesForCarouselId { get; set; }
        public string? CoverImgPath { get; set; }
        public string? Url { get; set; }
        public int? LibraryId { get; set; }
        public Library Library { get; set; }
    }
}

        