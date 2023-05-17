using Microsoft.AspNetCore.Mvc;

namespace Ders6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
