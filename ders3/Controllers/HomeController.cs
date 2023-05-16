using Microsoft.AspNetCore.Mvc;

namespace ders3.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
