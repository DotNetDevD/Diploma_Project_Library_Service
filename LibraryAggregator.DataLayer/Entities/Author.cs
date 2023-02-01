using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryAggregator.DataLayer.Entities;

public partial class Author
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AuthorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public virtual ICollection<AuthorsBook> AuthorsBooks { get; } = new List<AuthorsBook>();
}
