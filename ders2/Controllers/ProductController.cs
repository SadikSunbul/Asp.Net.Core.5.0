using System;
using System.Linq;
using ders2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

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
        /*
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
        
        */
        #endregion
        #region Asp.NET Core 5.0 - Kullanıcıdan Veri Alma Yöntemleri - QueryString Üzerinden Veri Alma
        //querystrıng nedir:guvenlık gerektırmıyen bılgıları url uzerınden tasınması ıcın kullanılan yapılandırmadır
        //querystrıng yapılan requestın turu ne olursa olsun query sıtrınf degerı tasınabılır 
        //public IActionResult Create1()
        //{
        //    return View();
        //}

        //query strıng ıcın deger gırme ...../Product/verial?sadık   --> dedıgımızde bıze sadık gı getırcektır

        //..../Product/verial?a=5&b=sadık
        //public IActionResult verial(string a,string b) //burada kı a degerı ?sonra yazılan yerden gelıcektır  //..../Product/verial?a=5&b=sadık
        //public IActionResult verial(QueryData data) //boylede yapılır
        //{
        //    //var querystrıng=Request.QueryString;//Request yapılan endpoınt e query strıng parametresı eklenmıs mı eklenmemısmı bununla ılgılı bılgı verırı 
        //    //var querya = Request.Query["a"].ToString();
        //    //var queryb = Request.Query["b"].ToString();

        //    return View();
        //}

        #endregion
        #region Asp.NET Core 5.0 - Kullanıcıdan Veri Alma Yöntemleri - Route Parameter Üzerinden Veri Alma
        //Route :rota ustunde verı tasıya bılıyoruz
        //query strıngeden farkı daha guvenlı burası queryde---> /user?name=max Route-->/user/max
        /*
        public IActionResult Create1()
        {
            return View();
        }
        //[HttpPost] bunu yazmıycaz degılse olmaz 
        //public IActionResult verial(string id) //boyle yakalıyabılırız
            public IActionResult verial(string id,string a,string b, Productcontroler my) //ozellestırılmıs de verılere karsılık seyler yazılcak sıra burada onemsız bunları bı tur ustundende elde edebılırız 
        {
            //var data1 = Request.RouteValues;
            //var data2 = Request.RouteValues["id"];
            string x = Request.Query["x"];
            var data = (id, a, b,x);
            ViewBag.my = my;
            return View(data);
        }
        */
        #endregion
        #region  Asp.NET Core 5.0 - Kullanıcıdan Veri Alma Yöntemleri - Header Üzerinden Veri Alma
        //header nedir: 
        //public IActionResult Create2()
        //{
        //    //postman uygullamasından verı alıcaz holders eklıycez verı buraya dusucek
        //    var headers = Request.Headers.ToList();
        //    return View();

        //}



        #endregion
        #region Asp.NET Core 5.0 - Kullanıcıdan Veri Alma Yöntemleri - Ajax Tabanlı Veri Alma
        //ajax : klaynt tabanlı ıstek yapmamızı saglıyan ve bu ısteklerın sonucunu almamızı saglıyan bır javascrrıp temmelı bı teknolojı
        public IActionResult Create3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VeriAl(ajaxdata data)
        {
            return View();
        }

        #endregion
    }
    public class ajaxdata
    {
        public string A { get; set; }
        public string B { get; set; }
    }
    public class QueryData
    {
        public int A { get; set; }
        public int B { get; set; }
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
