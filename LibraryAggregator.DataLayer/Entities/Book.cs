using System;
using System.Collections.Generic;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string? CoverImgPath { get; set; }

    public DateTime? PublishDate { get; set; }

    public string? Disctiption { get; set; }

    public int PageCount { get; set; }

    public virtual ICollection<Author> Authors { get; } = new List<Author>();

    public virtual ICollection<Genre> Genres { get; } = new List<Genre>();

    public virtual ICollection<Library> Libraries { get; } = new List<Library>();
}
