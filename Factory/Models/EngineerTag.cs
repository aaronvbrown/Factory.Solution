namespace Factory.Models
{
  public class EngineerTag
  {
    public int EngineerTagId { get; set; }
    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }
    public int TagId { get; set; }
    public Tag Tag { get; set; }
  }
}