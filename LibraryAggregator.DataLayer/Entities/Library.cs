using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Library
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LibraryId { get; set; }
    public string Name { get; set; } = null!;
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? ChartLink { get; set; }
    public string? DirectorPhotoLink { get; set; }
    public string? AgeGroup  { get; set; }
    public string? HistoryOfLibrary { get; set; }
    //public List<string>? ImagesForCorusel { get; set; }
    //public List<string>? OperatingModes { get; set; } 
    public virtual ICollection<BooksLibrary> BooksLibraries { get; } = new List<BooksLibrary>();
}
