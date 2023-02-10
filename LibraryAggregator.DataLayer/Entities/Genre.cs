using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public class Genre
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GenreId { get; set; }
    public string? Type { get; set; }
    public virtual ICollection<BooksGenre> BooksGenres { get; } = new List<BooksGenre>();
}
