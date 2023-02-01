using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public partial class BooksLibrary
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BooksLibrariesId { get; set; }

    public int BookId { get; set; }

    public int LibraryId { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Library Library { get; set; } = null!;
}
