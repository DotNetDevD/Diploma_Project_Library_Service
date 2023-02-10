using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public class AuthorsBook
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorsBooksId { get; set; }
    public int AuthorId { get; set; }
    public int BookId { get; set; }
    public virtual Author Author { get; set; } = null!;
    public virtual Book Book { get; set; } = null!;
}
