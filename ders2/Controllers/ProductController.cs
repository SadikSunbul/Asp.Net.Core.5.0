using System;
using Microsoft.AspNetCore.Mvc;

namespace ders2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()//get fonk bunlar aksını belırtmeadıgımız 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string txtProductName, string txtQuantity)//request netıcesınde gelen dataların hepsı actıom fonksıyonlarda parametrelerden yakalnmaktadır
        {
            Console.WriteLine("isim:" + txtProductName);
            Console.WriteLine("yas:" + txtQuantity);
            return View();
        }
    }
}
