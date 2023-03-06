namespace LibraryAggregator.DataLayer.Entities
{
  public class AdminEntryRequest : LoginRequest
  {
      public string ConfirmPassword { get; set; }
  }
}
