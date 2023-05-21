using Ders9._6.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ders9._6.Controllers
{
    public class HomeController : Controller
    {
        IWebHostEnvironment webHostEnvironment;
        IConfiguration configuration;
        public HomeController(IWebHostEnvironment _webHostEnvironment, IConfiguration _configuration)
        {
            webHostEnvironment= _webHostEnvironment;

            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var ADEGERİ = configuration["a"]; //buradakı a degerı Ortam kısmının Name sı degerını getırır 
            webHostEnvironment.IsDevelopment();
            webHostEnvironment.IsEnvironment("Devolopher");

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
