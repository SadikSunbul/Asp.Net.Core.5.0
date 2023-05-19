using Microsoft.AspNetCore.Mvc;

namespace Ders5.Controllers
{
    public class HomeController : Controller
    {
        #region Asp.NET Core 5.0 - Layout Yapılanması Nedir? RenderBody ve RenderSection Fonksiyonları Nelerdir?


        public IActionResult Index()
        {
            ViewBag.x = "Veri tasıma";
            return View();
        }
        public IActionResult Sayfa1()
        {
            return View();
        }
        public IActionResult Sayfa2()
        {
            return View();
        }

        #endregion
        #region Asp.NET Core 5.0 - _ViewStart ve _ViewImports Dosyaları Nelerdir?
        //_ViewStart dosyası:Asıl amacı tüm Viewler de kullanılması yapılması gereken ortak calısmaların yapıldıgı view dir .cshtml dır Bir nevi tüm viewlerin atasıdır dıyebılırız(ilk once bu render edılır)Viewlerde isim cok onemlıdır Views klasoru altında _ViewStart.cshtml olusturulması gerekır .Genellikle tüm viewlarda ortak kullancagımız Layout tanımlaması bu dosya içerisinde gerceklestırılır

        //_ViewImports dosyası:Razor sayfalrı ıcın kutuphane ve namespace tanımlamalarını sayfa sayfa farklı tanımlamaktansa ortak merkezı olarak tanımlamamızı saglayan bır dosyadır . Views Klasörü altında _ViewImports.cshtml isminde olusturulmalıdır

        #endregion
    }
}
