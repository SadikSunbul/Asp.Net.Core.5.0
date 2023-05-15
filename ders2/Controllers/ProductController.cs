using System;
using ders2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ders2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Kullanıcıdan post alma 

        [HttpGet]
        public IActionResult Create()//get fonk bunlar aksını belırtmeadıgımız 
        {
            var product = new Product();
            return View(product); //boyle gnderılımce altta kı post durumunda buradan gondermıs oldugumuz nesneye etkı etmıs oluruz
        }

        [HttpPost]
        //public IActionResult Create(string txtProductName, string txtQuantity)
        public IActionResult Create(Product product)//request netıcesınde gelen dataların hepsı actıom fonksıyonlarda parametrelerden yakalnmaktadır ısımlerı bırebır aynı olmalı cılastakıler bıle sıstem kendısı model bındın g yapar yakalr kendısı productun ıcerısındeı propertılerın ısımlerını bırebır ınput name sıne verrıden asp.net bunu algılar ve bızım yerımıze bındıng yaopar
        {
            //Form ıcerısındekı ınput nesnelerı post edıldıgınde bu nesnelere karsılık gelen propertylerın bır nesneyle otomatık olarak bınd edılırler

            return View();
        }
        #endregion

        #region  Asp.NET Core 5.0 - Kullanıcıdan Veri Alma Yöntemleri - Form Üzerinden Veri Alma

        #endregion
    }
}
