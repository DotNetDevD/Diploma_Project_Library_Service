using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities
{
    public class OperatingModes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OperatingModeId { get; set; }
        public string? StartWork { get; set; }
        public string? EndWork { get; set; }
        public string? CleanUpDay { get; set; }
        public int? LibraryId { get; set; }
        public Library? Libraries { get; set; }
    }
}
