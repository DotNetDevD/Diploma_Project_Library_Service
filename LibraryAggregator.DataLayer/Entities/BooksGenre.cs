using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public class BooksGenre
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BooksGenresId { get; set; }
    public int BookId { get; set; }
    public int GenreId { get; set; }
    public virtual Book Book { get; set; } = null!;
    public virtual Genre Genre { get; set; } = null!; 
}
