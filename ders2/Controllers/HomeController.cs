using Microsoft.AspNetCore.Mvc;

namespace ders2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
