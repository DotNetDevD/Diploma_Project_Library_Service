using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities
{
    public class ImagesFourCorusel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImagesFourCoruselId { get; set; }
        public string? Link { get; set; }
        public int? LibraryId { get; set; }
        public Library? Library { get; set; }
    }
}
