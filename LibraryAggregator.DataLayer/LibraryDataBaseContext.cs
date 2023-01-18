using System;
using System.Collections.Generic;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer;

public partial class LibraryDataBaseContext : DbContext
{
    public LibraryDataBaseContext()
    {
    }

    public LibraryDataBaseContext(DbContextOptions<LibraryDataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Library> Libraries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database = LibraryDataBase; Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Author__70DAFC340477FA73");

            entity.ToTable("Author");

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);

            entity.HasMany(d => d.Books).WithMany(p => p.Authors)
                .UsingEntity<Dictionary<string, object>>(
                    "AuthorsBook",
                    r => r.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AuthorsBo__BookI__3C69FB99"),
                    l => l.HasOne<Author>().WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__AuthorsBo__Autho__3B75D760"),
                    j =>
                    {
                        j.HasKey("AuthorId", "BookId").HasName("PK__AuthorsB__1304F01476A5E937");
                    });
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C20760C1375B");

            entity.ToTable("Book");

            entity.HasIndex(e => e.Isbn, "UQ__Book__447D36EACD6F2BF4").IsUnique();

            entity.Property(e => e.CoverImgPath).HasMaxLength(50);
            entity.Property(e => e.Disctiption).HasMaxLength(200);
            entity.Property(e => e.Isbn)
                .HasMaxLength(23)
                .HasColumnName("ISBN");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasMany(d => d.Genres).WithMany(p => p.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "BooksGenre",
                    r => r.HasOne<Genre>().WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__BooksGenr__Genre__4BAC3F29"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__BooksGenr__BookI__4AB81AF0"),
                    j =>
                    {
                        j.HasKey("BookId", "GenreId").HasName("PK__BooksGen__CDD89250BBB0595F");
                    });

            entity.HasMany(d => d.Libraries).WithMany(p => p.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "BooksLibrary",
                    r => r.HasOne<Library>().WithMany()
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__BooksLibr__Libra__440B1D61"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__BooksLibr__BookI__4316F928"),
                    j =>
                    {
                        j.HasKey("BookId", "LibraryId").HasName("PK__BooksLib__D7F3A67265C47720");
                    });
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PK__Genre__0385057E91D54978");

            entity.ToTable("Genre");

            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Library>(entity =>
        {
            entity.HasKey(e => e.LibraryId).HasName("PK__Library__A136475F301D76A8");

            entity.ToTable("Library");

            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
