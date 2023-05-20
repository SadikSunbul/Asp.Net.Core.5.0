using Microsoft.AspNetCore.Mvc;

namespace Ders9._2.AreasYapılanması.Areas.Fatura_Paneli.Controllers
{
    [Area("Fatura_Paneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["data"];
            return View();
        }
    }
}
