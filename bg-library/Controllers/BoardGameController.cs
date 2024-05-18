using Microsoft.AspNetCore.Mvc;

namespace bg_library.Controllers
{
    public class BoardGameController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
