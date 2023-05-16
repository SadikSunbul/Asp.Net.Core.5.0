using Microsoft.AspNetCore.Mvc;

namespace ders4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
