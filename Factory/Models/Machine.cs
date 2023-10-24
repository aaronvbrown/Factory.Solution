using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The machine description cannot be blank!")]
    public string Description { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }
  }
}