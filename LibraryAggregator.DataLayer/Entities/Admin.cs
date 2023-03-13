namespace LibraryAggregator.DataLayer.Entities
{
  public class Admin
  {
    public int AdminId { get; set; }
    public string Login { get; set; } = null!;
    public string Password { get; set; } = null!;
    public int LibraryId { get; set; }
    public  Library Library { get; set; }
  }
}
