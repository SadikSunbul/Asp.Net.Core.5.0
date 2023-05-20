using Dependency_Injection_IoC_Yapılanması.Controllers.Services;
using Dependency_Injection_IoC_Yapılanması.Controllers.Services.Interface;
using Dependency_Injection_IoC_Yapılanması.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_IoC_Yapılanması.Controllers
{
    public class HomeController : Controller
    {
        //readonly ILog Log;
        //public HomeController(ILog log)
        //{
        //    Log = log;
        //}

        public IActionResult Index([FromServices]ILog Log) //[FromServices]ILog log bu contaınerdan bu turde bı verı gelıcegını belırtıyor yanı ctor a gerek kalmıyor burada
        {
            // ConsoleLog log = new ConsoleLog(); //boyle yapılmaması gerekır buradakı logu text olarak degıstırmek ısteyınce buraya gelıp manuel bı sekılde degısıklık yapmamız gerekecegınden dolayı boyle yapmamalıyız IoC ıle yapmalıyız
            //log.Log();
            Log.Log();

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
