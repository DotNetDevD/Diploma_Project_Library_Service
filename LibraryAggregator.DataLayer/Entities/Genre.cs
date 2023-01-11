using System;
using System.Collections.Generic;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Genre
{
    public int GenreId { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
