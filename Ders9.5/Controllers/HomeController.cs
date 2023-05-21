using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace Ders9._5_.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration configuration;
        public HomeController(IConfiguration data)
        {
            configuration= data;
        }
        public IActionResult Index()
        {


            var veri=configuration["MailBilgileri:MailBilgileri"];


            var connectionstrıng = configuration.GetConnectionString("SQL");
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionstrıng);
            builder.UserID = configuration["SQL:KullanıcıAdı"];
            builder.Password = configuration["SQL:Şifre"];

            var x = builder.ConnectionString; //dagınıc ları topladık 

            return View();
        }
    }
}
