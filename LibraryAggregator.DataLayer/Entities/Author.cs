using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Author
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? CoverImg { get; set; }

    public string? Biography { get; set; }

    public virtual List<AuthorsBook> AuthorsBooks { get; } = new List<AuthorsBook>();
}
