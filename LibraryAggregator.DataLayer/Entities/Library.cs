using System;
using System.Collections.Generic;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Library
{
    public int LibraryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<BooksLibrary> BooksLibraries { get; } = new List<BooksLibrary>();
}
