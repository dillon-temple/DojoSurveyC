
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
        public IActionResult Results(Ninja ninja)
        {
            return View(ninja);
        }
    }
}