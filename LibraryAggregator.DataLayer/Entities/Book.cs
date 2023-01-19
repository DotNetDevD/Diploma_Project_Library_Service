﻿using System;
using System.Collections.Generic;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string? CoverImgPath { get; set; }

    public DateTime? PublishDate { get; set; }

    public string? Description { get; set; }

    public int PageCount { get; set; }

    public virtual ICollection<AuthorsBook> AuthorsBooks { get; } = new List<AuthorsBook>();

    public virtual ICollection<BooksGenre> BooksGenres { get; } = new List<BooksGenre>();

    public virtual ICollection<BooksLibrary> BooksLibraries { get; } = new List<BooksLibrary>();
}
