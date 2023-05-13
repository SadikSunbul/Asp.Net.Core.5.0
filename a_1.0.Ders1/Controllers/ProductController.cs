using a_1._0.Ders1.Models;
using a_1._0.Ders1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace a_1._0.Ders1.Controllers
{
	//[NonController] //Hem controler olusturup dısarıdan request almak ıstemıyordsak yapılır
	public class ProductController : Controller
	{/*
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
			var products = new List<Product>()
			{
				new Product{Id=1,ProductName="A product",Quantity=10},
				new Product{Id=2,ProductName="B product",Quantity=15},
				new Product{Id=3,ProductName="C product",Quantity=20}
			};

			/*
             4 farklı sekılde verı gondere bılmekteyiz
            1 i ile Model bazlı verı gonderme 3 u verı tasıama kontrollerı ıle gonderme
             
			#region Model Bazlı Veri Gonderem
			//uretılen datayı view e gonderceksek 2 taraftada ayar yapılmalıdır 
			// return View(products); //bu datayı gonderıyoruz
			/*arkada 
             @using a_1._0.Ders1.Models;
                @model List<Product> //burada bu ayarı yapmamız gerekır gelecek datanın turunu bellı ettık @Model üsteki nı kullanıcak sak yazılır 

                <ul>
                    @{
                        foreach (var product in Model)
                        {
                            <li>@product.ProductName</li>
                        }
                    }
                </ul>
			#endregion
			#region Veri Taşıma Kontrolleri
			#region ViewBag
			//Viewe gonderılecek tasınacak datayı dynamıc sekılde tanımlanan bır degıskenle tasımamızı saglayan bir veri tasıma kontroludur 
			ViewBag.Products = products; //veri gonderildi
			/*
                             <ul>
                    @{
                        foreach (var product in ViewBag.Products as List<Product>) //burada turunu bellı etmemız gerekır cunku altarafta product . deyınce name gelmez
                        {
                            <li>@product.ProductName</li>
                        }
                    }
                </ul
                             
			#endregion
			#region ViewData
			//ViewBag de oldugu gıbı actıon dakı datayı wıeve tasımamızı sagglayan bır kontroldur
			ViewBag["Product"] = products; //boxing anboxing etmemız gerekır
										   //object ıle gonderılır 
			#endregion
			#region TempData
			//ViewData de oldugu gıbı actıon dakı datayı wıeve tasımamızı sagglayan bır kontroldur  fark farklı iki actıon arasında verı tasaımamızı saglar
			string data = JsonSerializer.Serialize(products); //bunu yapınca alttakı actona gonderılrı

			TempData["products"] = data;
			#endregion
			#endregion

			TempData["x"] = 5;
			ViewBag.x = 5;
			ViewData["x"] = 5;

			return RedirectToAction("Index2", "kontroler da yazılabılır aynı controller da ıse yazmayız Product"); //Index2 actıonunu calıstırır
		}
		public IActionResult Index2()
		{
			var v1 = ViewBag.x; //verıyı tasımaz
			var v2 = ViewData["x"];//verıyı tasımaz
			var v3 = TempData["x"];//verıyı tasır burası bı ust actıondakı verıyı buraya tasımamızı saglar

			var v4 = TempData["products"].ToString();//komplex turlerde turu sterılıze etmemız gerekır
			List<Product> Product = JsonSerializer.Deserialize<List<Product>>(v4);
			return View();
		}

		[NonAction] //burası artık Actıon degıldır dısarıdan request karsılamazlar sadece iş mantıgı yuruten bır metotdur
		public void x()
		{

		}

		//controler sadece requestlerı karsılamktadır bı algorıtma mantıgı yurutmemelıdır ve bu requste karsılık algorıtmaları servıslerı tetıklemelıdır işin komutanıdır controler işi yapmaz yaptırtır içerisinde iş mantıgı olmamalıdır controlerın 
		//Actionlar ıse Controlera yaverı ıgbı algorıtmık yonlendırme yaparlar ıs yapmaz iş yapanları tetıkler


		#endregion
		*/
		public IActionResult GetProducts()
		{


			#region Asp.NET Core 5.0 - View'e Tuple Nesne Gönderimi ve Kullanımı
			//tuple ne : ıcınde bırden fazla degerı referans ede bılır 


			Product product = new Product
			{
				Id = 1,
				ProductName = "A Product",
				Quantity = 15
			};


			User user = new()
			{
				Id = 1,
				İsim = "Sadık",
				Soyİsim = "Sünbül"
			};

			UserProduct userproduct = new UserProduct()
			{
				User = user,
				Product = product
			};

			#endregion


			return View(userproduct);
		}
	}
}
