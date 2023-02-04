using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.ViewModel
{
    public class BookVM
    {
        public int BookId { get; set; } 
        public string? Isbn { get; set; } 

        public string? Title { get; set; } 

        public DateTime? PublishDate { get; set; }

        public string? AuthorFullName { get; set; }

        public string? CoverImgPath { get; set; }

        public string? Description { get; set; }

        public List<Genre> GenreList { get; set; } 
        public int PageCount { get; set; }

        public BookVM()
        {
            GenreList = new List<Genre>();

        }
    }
}
