using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities
{
    public class OperatingModes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OperatingModeId { get; set; }
        public string? Monday { get; set; }
        public string? Tuesday { get; set; }
        public string? Wednesday { get; set; }
        public string? Thursday { get; set; }
        public string? Friday { get; set; }
        public string? Saturday { get; set; }
        public string? Sunday { get; set; }
        public int? LibraryId { get; set; }
        public Library Libraries { get; set; }
    }
}
