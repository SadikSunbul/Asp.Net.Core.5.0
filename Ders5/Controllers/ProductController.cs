using Microsoft.AspNetCore.Mvc;

namespace Ders5.Controllers
{
    public class ProductController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
