using System;
using ders2.Models;
using Microsoft.AspNetCore.Http;
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
        /*
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
        */
        #endregion

        #region  Asp.NET Core 5.0 - Kullanıcıdan Veri Alma Yöntemleri - Form Üzerinden Veri Alma
        //kullanıcıdan verı alcaksak post kullanılır
        public IActionResult Get()
        {
            return View();
        }

        Productcontroler deneme = new Productcontroler()
        {
            txtValue1 = "1",
            txtValue2 = "2",
            txtValue3 = "3"
        };
        public IActionResult Creatte()
        {
           

            return View(deneme);
        }

        [HttpPost]
        //public IActionResult verial(IFormCollection datas) //post edılen form ıcerısındekı dataları name ıle yakalar
        //public IActionResult verial(string txtValue1,string txtValue2,string txtValue3) //bunların hepsı ıle verı alınabılır
        //public IActionResult verial(Productcontroler productcontroler)
        public IActionResult verial(MyClass productcontroler)//burasıda calısır ıllakı bınd edılen clastan verı tasınmayabılır bınd etmekzorunlu degıl ısımlerı bıre bır aynı verdıgımız zaman da aynı bınd etmıs gıbı kendısı otomatık bır sekılde ayarlıycaktır 
        {
            //var data=datas["txtValue1"].ToString();
            Console.WriteLine(deneme.txtValue1);
            Console.WriteLine(deneme.txtValue2);
            Console.WriteLine(deneme.txtValue3);
            return View();

        }
        

        #endregion
    }
    public class Productcontroler
    {
        public string txtValue1 { get; set; }
        public string txtValue2 { get; set; }
        public string txtValue3 { get; set; }
    }
    public class MyClass
    {
        public string txtValue1 { get; set; }
        public string txtValue2 { get; set; }
        public string txtValue3 { get; set; }
    }
}
