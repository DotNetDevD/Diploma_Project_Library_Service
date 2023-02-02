using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Library
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LibraryId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? ChartLink { get; set; }
    public string? DirectorPhotoLink { get; set; }
    public string? AgeGroup  { get; set; }
    public string? ShortDiscription { get; set; }
    public string? CoverImage { get; set; }
    public string? HistoryOfLibrary { get; set; }
    public virtual ICollection<ImagesFourCorusel>? ImagesForCorusel { get; set; }
    public virtual ICollection<OperatingModes>? OperatingModes { get; set; } 
    public virtual ICollection<BooksLibrary> BooksLibraries { get; } 

    public Library()
    {
        ImagesForCorusel = new List<ImagesFourCorusel>();
        OperatingModes = new List<OperatingModes>();
        BooksLibraries = new List<BooksLibrary>();
    }
}
