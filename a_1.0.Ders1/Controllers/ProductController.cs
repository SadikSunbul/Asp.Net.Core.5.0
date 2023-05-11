using a_1._0.Ders1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace a_1._0.Ders1.Controllers
{
    //[NonController] //Hem controler olusturup dısarıdan request almak ıstemıyordsak yapılır
    public class ProductController : Controller
    {
        public IActionResult UrunleriGetir()
        {
            Product product = new Product();
            // burada verıtabanı ıslemelerı veyahutta dıger verıler elde edıle bılrı ve bu verılerı vıeve gondere bılrıız
            ViewResult result = View(); //işleyip altta dondurur bu drekt metotdun adında varsa vıew onu getırır
            ViewResult result1 = View("ahmet"); //burada baska ısımlı bır dosysayı acar
            return result;
            //return View(); //burası dırekt olarak Views içerisinden Product içerisinden UrunleriGetir e gıdıcektır kendısı bunu anlar
        }

        #region ViewResult
        //Response olarak bır View dosyasını (.cshtml) render etmemizi sağlayan action türdür

        //public ViewResult GetProduct()
        //{
        //    ViewResult result = View();
        //    return result;
        //}
        #endregion
        #region PartialViewResult
        //Yine bir View dosyasını (.cshtml) render etmemızı saglayan bır actıon turudur
        //ViewResult dan temel farkı clıent tabanı yapılan Ajax isteklerınde kullanıma yatkın olmasıdır
        //Teknik farkı ıse ViewResult_ViewStrat.cshtml dosyasını baz alır .Lakın PartialViewResult ise ilgili dosyayı baz almadan render edilir.
        //bellı bır alanı render eder burası sayfayı tamamen render etmez

        //public PartialViewResult getProducts()
        //{
        //    PartialViewResult result = PartialView();
        //    return result;  
        //}
        #endregion
        #region JsonResult
        //Üretilen datayı json turune donusturup donduren bir action turudur

        //public JsonResult getProducts()
        //{
        //    JsonResult result=Json(new Product
        //    {
        //        Id = 1,
        //        ProductName = "Terlik",
        //        Quantity = 1,
        //    }); //buradakı degerı json formatına dondurup tasımıs olduk 

        //    return result;
        //}

        //jspn olarak gonderır
        #endregion
        #region EmptyResult
        //Bazen gelen ıstekler netıcesınde herhangıbır sey dondurmek ıstemeyebılırız boyle durumlarda EmptyResult action turunu kullanabılırız

        //public EmptyResult getproduct()
        //{
        //    return new EmptyResult();
        //respon yanı cevap vardır ama bostur
        //}
        //aynıs seyler
        //public void get()
        //{
        //    //....
        //}
        #endregion
        #region ContentResult
        //Istek netıcesınde cevap olarak metınsel bır deger dondurmemızı saglayan actıon turudur

        //public ContentResult ger()
        //{
        //    ContentResult result = Content("Sebebsız bos yere ayrılacaksan ");
        //    return result;
        //    //txt olarka gonderır
        //}
        #endregion
        #region ActionResult
        //Gelen bır ıstek netıcesınde gerıye dondurulecek actıon turlerı degıskenlık gosterebildiği durumlarda kullanılan bır actıon turudur
        //ActionResult tüm actıon turlerını karsılayan ana turdur

        //public ActionResult UrunleriUpdate()
        //{
        //    if(true) {
        //        //..
        //        return Json(new object());
        //    }
        //    else if (true)
        //    {
        //        return Content("asfsdgdshfdfhh");
        //    }
        //    //hepsını dondure bılır object gıbı bısey 
        //    return View();
        //}
        #endregion
        #region IActionResult

        //public IActionResult actionResult()
        //{

        //}
        #endregion


        #region Asp.NET Core 5.0 - NonAction ve NonController Attributeları

        public IActionResult Index()
        {
            var products=new List<Product>()
            {
                new Product{Id=1,ProductName="A product",Quantity=10},
                new Product{Id=2,ProductName="B product",Quantity=15},
                new Product{Id=3,ProductName="C product",Quantity=20}
            };

            /*
             4 farklı sekılde verı gondere bılmekteyiz
            1 i ile Model bazlı verı gonderme 3 u verı tasıama kontrollerı ıle gonderme
             */
            #region Model Bazlı Veri Gonderem
            //uretılen datayı view e gonderceksek 2 taraftada ayar yapılmalıdır 
            return View(products); //bu datayı gonderıyoruz
            #endregion
            #region Veri Taşıma Kontrolleri
            #region ViewBag

            #endregion
            #region ViewData

            #endregion
            #region TempData

            #endregion
            #endregion

            return View();
        }

        [NonAction] //burası artık Actıon degıldır dısarıdan request karsılamazlar sadece iş mantıgı yuruten bır metotdur
        public void x()
        {

        }

        //controler sadece requestlerı karsılamktadır bı algorıtma mantıgı yurutmemelıdır ve bu requste karsılık algorıtmaları servıslerı tetıklemelıdır işin komutanıdır controler işi yapmaz yaptırtır içerisinde iş mantıgı olmamalıdır controlerın 
        //Actionlar ıse Controlera yaverı ıgbı algorıtmık yonlendırme yaparlar ıs yapmaz iş yapanları tetıkler


        #endregion
    }
}
