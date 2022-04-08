using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SweetMarket.Models;
using System.Collections.Generic;
using System.Linq;


namespace SweetMarket.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetMarketContext _db;

    public HomeController(SweetMarketContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index(string search)
    {
      List<Treat> model = _db.Treats.Where(x => x.TreatName.Contains(search) || search == null).ToList();
      return View(model);
    }
  }
}