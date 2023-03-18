namespace LibraryAggregator.DataLayer.Entities
{
  public class Admin
  {
    public int AdminId { get; set; }
    public string Login { get; set; } 
    public string Password { get; set; }
    public int LibraryId { get; set; }
    public  Library Library { get; set; }
    public string Message { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
  }
}
