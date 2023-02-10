using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public class Library
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LibraryId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? MapLink { get; set; }
    public string? DirectorPhotoLink { get; set; }
    public string? AgeGroup  { get; set; }
    public string? ShortDiscription { get; set; }
    public string? CoverImgPath { get; set; }
    public string? Url { get; set; }
    public string? HistoryOfLibrary { get; set; }
    public virtual ICollection<ImagesForCarousel> ImagesForCarousel { get; set; } = new List<ImagesForCarousel>();
    public virtual ICollection<OperatingModes> OperatingModes { get; set; } = new List<OperatingModes>();
    public virtual ICollection<BooksLibrary> BooksLibraries { get; } = new List<BooksLibrary>();
}
