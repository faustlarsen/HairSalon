using Microsoft.AspNetCore.Mvc;

namespace Hairsalon.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}