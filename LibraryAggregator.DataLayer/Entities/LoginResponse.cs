namespace LibraryAggregator.DataLayer.Entities
{
  public class LoginResponse
  {
    public bool IsSuccess { get; set; }
    public string Token { get; set; }
    public DateTime? ExpiresAt { get; set; }
  }
}
