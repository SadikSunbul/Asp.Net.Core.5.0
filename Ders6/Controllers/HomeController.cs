using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ders6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var isim=new List<string> { "a", "b", "c" };
            return View(isim);
        }
    }
}
