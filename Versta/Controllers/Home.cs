using Microsoft.AspNetCore.Mvc;

namespace Versta.Controllers
{
    public class Home : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
