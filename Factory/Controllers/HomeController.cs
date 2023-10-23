using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactorContext _db;

    public HomeController(ToDoListContext db)
    {
      _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index()
    {
      Engineer[] engineers = _db.Engineers.ToArray[];
      Machine[] machines = _db.Machines.ToArray[];
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("machines", machines);
      model.Add("engineers", engineers);
      return View(model);
    }
  }
}