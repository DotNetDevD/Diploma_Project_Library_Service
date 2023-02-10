using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAggregator.DataLayer.Entities;

public class Author
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? CoverImgPath { get; set; }
    public string? Url { get; set; }
    public string? Biography { get; set; }
    public virtual ICollection<AuthorsBook> AuthorsBooks { get; } = new List<AuthorsBook>();
}
