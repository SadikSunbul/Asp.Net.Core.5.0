using Ders9._4.appsettings.jsonDosyasıNedir.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ders9._4.appsettings.jsonDosyasıNedir.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration _configuration;
        readonly ilİnfo _mail;
        public HomeController(IConfiguration configuration,IOptions<ilİnfo> mail)
        {
            _configuration= configuration;
            _mail = mail.Value; //boyle yakalanır 
        }

        public IActionResult Index()
        {
            //veri okuma IConfigratıon Arayuzu nedır? Asp.Net core IoC provider ında bulunan bır servistir Bu serviste Uygulamadakı appsettings.json dosyasını okumakta ve ıcerısındekı value ları bıze getırmektedır .Dolayısı ıle IoC den bu servisi herhangi bir controlerdan dependectıon Injection ile talep edilebilir ve appsettings.json dosyasındakı konfıgrasyonları kullanabılırız ctor a ekledık

            string data=_configuration["OrnekMetin"]; //Index ustunde erısme
            var data1 = _configuration["Person"]; //null doner
            var data2 = _configuration["Person:Name"]; 

            // ->GetSectiom Methodu ile veri okuma nasıl yapılır? daha fazla bılgı verır ustekı dagha fazla kullanılır

            var data3=_configuration.GetSection("Person"); //null gelmez
            var data4=_configuration.GetSection("Person:Name");

            //->Get Methoduyla verileri uygun nesneyle eslestırme

            var data5=_configuration.GetSection("Person").Get(typeof(Person)); //person altındakı verılerı Person sınıfına donduruyor 

            return View();
        }

        public IActionResult Privacy()
        {
            //var host = _configuration["MailInfo:Host"];
            //var Port = _configuration["MailInfo:Port"];

            //var veriler=_configuration.GetSection("MailInfo").Get<ilİnfo>();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
