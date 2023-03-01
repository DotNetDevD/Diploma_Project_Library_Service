using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public class BooksLibrary
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BooksLibrariesId { get; set; }
    public int BookId { get; set; }
    public int LibraryId { get; set; }
    public int Count { get; set; }
    public int BookedBook { get; set; }
    public int FreeBook { get; set; }
    public bool IsFreeBook { get; set; } = true;
    public virtual Book? Book { get; set; }
    public virtual Library? Library { get; set; }
    public virtual ICollection<Booking> Booking { get; set; }
}