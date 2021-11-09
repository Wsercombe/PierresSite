using Microsoft.AspNetCore.Mvc;

namespace PierresSite.Controllers
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