
using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{

    public class HomeController : Controller
    {

        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Results")]
        public IActionResult Results(string location, string fullname, string language, string comment)
        {
            ViewBag.location = location;
            ViewBag.fullname = fullname;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View();
        }
    }
}