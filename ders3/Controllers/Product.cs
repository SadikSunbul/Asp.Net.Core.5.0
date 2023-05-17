using ders3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace ders3.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Asp.NET Core 5.0 - Tuple Nesne Post Etme ve Yakalama
        //Egerkı bınf mekanızmasında tuple turde bır nesne kullanıyorsak bu tuple nesnesındekı datalar/degerler/nesneler / object olusturulup verilmesı gerekmektedır 
        public IActionResult Get()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create()
        {
            var tuple = (new Models.Product(), new User()); //null olmaması ıcın yaptık 
            return View(tuple);
        }
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Models.Product product, [Bind(Prefix = "Item2")] User user) //burada ıtem ıle verılmelı dıger tarafta ıstedıgın kadar ezmıs  ol burada ıselmez
        {
            return View();
        }
        #endregion
    }
}
