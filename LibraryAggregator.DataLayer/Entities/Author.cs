using System;
using System.Collections.Generic;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Author
{
    public int AuthorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
