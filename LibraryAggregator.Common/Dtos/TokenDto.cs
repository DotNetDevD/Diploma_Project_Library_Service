using LibraryAggregator.DataLayer.Entities.Enum;

namespace LibraryAggregator.Common.Dtos
{
  public class TokenDto
  {
    public string AccessToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
    public string Message { get; set; } = nameof(AdminEnum.Admin);
  }
}
