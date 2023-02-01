using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Book
{

    public Book()
    {
        AuthorsBooks = new List<AuthorsBook>();
        BooksGenres  = new List<BooksGenre>();
        BooksLibraries = new List<BooksLibrary>();
    }
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Isbn { get; set; } = null!;

    public string? CoverImgPath { get; set; }

    public DateTime? PublishDate { get; set; }

    public string? Description { get; set; }

    public int PageCount { get; set; }

    public virtual ICollection<AuthorsBook> AuthorsBooks { get; }

    public virtual ICollection<BooksGenre> BooksGenres { get; } 

    public virtual ICollection<BooksLibrary> BooksLibraries { get; } 
}
