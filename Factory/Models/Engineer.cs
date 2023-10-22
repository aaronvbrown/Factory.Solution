using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string FirstName { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}