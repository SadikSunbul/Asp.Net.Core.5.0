using Microsoft.AspNetCore.Mvc;

namespace Ders9._2.AreasYapılanması.Areas.Yönetim_Paneli.Controllers
{
    [Area("Yönetim_Paneli")] //ıstedıgın ısmı vere bılrısın 
    public class HomeController : Controller
    {
        //2 tane home controller var derleyıcı hata vermedı ama projeyı calıstırınca hata verıcektır [Area("Yönetim")]
        public IActionResult Index()
        {
            TempData["data"] = "sebebsız ayrılacaksan bos yere ...";
            return RedirectToAction("Index","Home", new { area= "Fatura_Paneli" });
        }
    }
}
