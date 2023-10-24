using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineer FirstName cannot be empty!")]
    public string FirstName { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}