using System.Text.Json.Serialization;

namespace LibraryAggregator.DataLayer.Entities
{
  public class LibraryAdmin
  {
    public int AdminId { get; set; }
    public string Email { get; set; }
    [JsonIgnore]
    public byte[] PasswordHash { get; set; }
    [JsonIgnore]
    public byte[] PasswordSalt { get; set; }
    public Guid RefreshToken { get; set; }
  }
}
