using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public class BooksLibrary
{
    public int BooksLibrariesId { get; set; }
    public int BookId { get; set; }
    public int LibraryId { get; set; }
    public int Count { get; set; }
    public virtual Book Book { get; set; } 
    public virtual Library Library { get; set; }
    public virtual ICollection<Booking> Boookings { get; set; }
}