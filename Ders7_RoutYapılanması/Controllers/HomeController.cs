using Ders7_RoutYapılanması.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ders7_RoutYapılanması.Controllers
{
    [Route("[controller]/[action]")] // home/ındex
    [Route("ana/[action]")] // ana/ındex
    [Route("ana")] // ana/... alttabelirlencek
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index(string id,string x, string y) //buradaki degerleri rout kısmından cekıcez
        [Route("in/{id?}")]
        public IActionResult Index(int? Id)  //buarası calısacagında  ana/in deyince bırası calısacaktır
        {
            //ustekı gıbıde yakalana bılır boylede yakalanabılır 
            var data2 = Request.RouteValues["id"];
            var data1 = Request.RouteValues["x"];
            var data3 = Request.RouteValues["y"];

            var data4 = Request.Query["q"]; //buda dırekt olarak q=5 i yakalar 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
