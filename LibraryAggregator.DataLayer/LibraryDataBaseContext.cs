using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Seed;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer;

public partial class LibraryDataBaseContext : DbContext
{
    public LibraryDataBaseContext(DbContextOptions<LibraryDataBaseContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<Booking> Booking { get; set; }
    public virtual DbSet<BookStatus> BookStatus { get; set; }
    public virtual DbSet<Client> Client { get; set; }
    public virtual DbSet<Author> Author { get; set; }
    public virtual DbSet<AuthorsBook> AuthorsBook { get; set; }
    public virtual DbSet<Book> Book { get; set; }
    public virtual DbSet<BooksGenre> BooksGenre { get; set; }
    public virtual DbSet<BooksLibrary> BooksLibrarie { get; set; }
    public virtual DbSet<Genre> Genre { get; set; }
    public virtual DbSet<Library> Library { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Author__70DAFC34E9BADC14");

            entity.ToTable("Author");

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
        });

        modelBuilder.Entity<AuthorsBook>(entity =>
        {
            entity.HasKey(e => e.AuthorsBooksId).HasName("PK__AuthorsB__E0C25E886755A2F4");

            entity.HasOne(d => d.Author).WithMany(p => p.AuthorsBooks)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AuthorsBo__Autho__3B75D760");

            entity.HasOne(d => d.Book).WithMany(p => p.AuthorsBooks)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AuthorsBo__BookI__3C69FB99");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C207BE51473D");

            entity.ToTable("Book");

            entity.HasIndex(e => e.Isbn, "UQ__Book__447D36EA06ADE972").IsUnique();

            entity.Property(e => e.CoverImgPath).HasMaxLength(3000);
            entity.Property(e => e.Description).HasMaxLength(3000);
            entity.Property(e => e.Isbn)
                .HasMaxLength(23)
                .HasColumnName("ISBN");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<BooksGenre>(entity =>
        {
            entity.HasKey(e => e.BooksGenresId).HasName("PK__BooksGen__8D4DA176FE0124EF");

            entity.HasOne(d => d.Book).WithMany(p => p.BooksGenres)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BooksGenr__BookI__46E78A0C");

            entity.HasOne(d => d.Genre).WithMany(p => p.BooksGenres)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BooksGenr__Genre__47DBAE45");
        });

        modelBuilder.Entity<BooksLibrary>(entity =>
        {
            entity.HasKey(e => e.BooksLibrariesId).HasName("PK__BooksLib__D9FCBEB6058BCAE3");

            entity.HasOne(d => d.Book).WithMany(p => p.BooksLibraries)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BooksLibr__BookI__412EB0B6");

            entity.HasOne(d => d.Library).WithMany(p => p.BooksLibraries)
                .HasForeignKey(d => d.LibraryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BooksLibr__Libra__4222D4EF");

            entity.HasMany(item => item.Boookings).WithOne(item => item.BooksLibrary)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PK__Genre__0385057E1C92AF8D");

            entity.ToTable("Genre");

            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Library>(entity =>
        {
            entity.HasKey(e => e.LibraryId).HasName("PK__Library__A136475FA23EBF26");

            entity.ToTable("Library");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });


        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasIndex(item => item.Email).IsUnique();
            entity.HasIndex(item => item.PhoneNumber).IsUnique();

        });

        modelBuilder.Entity<BookStatus>(entity =>
        {
            entity.HasKey(item => item.BookStatusId).HasName("PK__BookStatus");
        });

        modelBuilder.Entity<Booking>(entity =>
       {
           //entity.HasKey(item => item.BookingId).HasName("PK__Booking");
           entity.Property(item => item.Code).HasMaxLength(6);

           entity.HasOne(item => item.BookStatus)
           .WithOne(item => item.Booking)
           .OnDelete(DeleteBehavior.ClientCascade);
       });

        //it's Seed 
        modelBuilder.SeedAuthors();
        modelBuilder.SeedBooks();
        modelBuilder.SeedGenre();
        modelBuilder.SeedAuthorsBook();
        modelBuilder.SeedBooksGenre();
        modelBuilder.SeedLibraries();
        modelBuilder.SeedOperatingModes();
        modelBuilder.SeedImagesFourCorusel();
        modelBuilder.SeedBooksLibrary();
        modelBuilder.SeedBookStatuses();
        modelBuilder.SeedBooking();
        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
