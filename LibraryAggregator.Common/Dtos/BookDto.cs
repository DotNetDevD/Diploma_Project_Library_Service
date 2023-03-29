using LibraryAggregator.DataLayer.Entities.Enum;

namespace LibraryAggregator.Common.Dtos;
public class LibraryDto
{
  private bool answer;
  public int Id { get; set; }
  public string Title { get; set; }
  public int Count { get; set; }
  public string FioAuthor { get; set; }
  public string Status { get; set; }
  public int booksLibrariesId { get; set; }
  public int FreeBook { get; set; }
  public bool isFreeBook
  {
    get { return this.answer; }
    set { this.answer = FreeBook > 0 ? true : false; }
  }
  public int  Booked { get; set; }


}


