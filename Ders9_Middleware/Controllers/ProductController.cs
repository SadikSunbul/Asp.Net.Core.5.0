using Microsoft.AspNetCore.Mvc;

namespace Ders9_Middleware.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
