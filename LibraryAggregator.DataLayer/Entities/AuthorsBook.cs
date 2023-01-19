﻿using System;
using System.Collections.Generic;

namespace LibraryAggregator.DataLayer.Entities;

public partial class AuthorsBook
{
    public int AuthorsBooksId { get; set; }

    public int AuthorId { get; set; }

    public int BookId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;
}
