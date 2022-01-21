namespace Parks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public string State { get; set; }

    public string Near { get; set; }

    public string ParkOverview { get; set; }

    public int Acres { get; set; }
  }
}