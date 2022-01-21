namespace Parks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public string State { get; set; }

    public string Established { get; set; }

    public string Acres { get; set; }

    public string OverView { get; set; }
  }
}