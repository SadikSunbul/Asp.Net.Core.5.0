using Microsoft.AspNetCore.Mvc;

namespace ders3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Asp.NET Core 5.0 - Tuple Nesne Post Etme ve Yakalama
        public IActionResult Get()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
