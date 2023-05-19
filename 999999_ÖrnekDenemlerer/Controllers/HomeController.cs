using _999999_ÖrnekDenemlerer.Models;
using _999999_ÖrnekDenemlerer.Models.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Reflection.Metadata.Ecma335;

namespace _999999_ÖrnekDenemlerer.Controllers
{
   
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Machine()
        {
            return View();
        }
        
        public IActionResult News()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(string username, string password) 
        {
           bool kontrol= DataBases.KullanıcıcGiriş(username, password);

            if (kontrol)
            {
                return RedirectToAction("Index", "Logged");

            }
            else
            {
                ViewBag.Giriş = "Girişhatalı";
                return View();
            }

            
        }
        
        public IActionResult Log()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Log(Kullanıcı kullanıcı,string şifre2)
        {
            if(ModelState.IsValid)
            {
                if (kullanıcı.Şİfre==şifre2)
                {
                    bool kontrol;
                    string mesaj;
                    (kontrol, mesaj) = DataBases.KullanıcıEkle(kullanıcı);
                    ViewBag.KayıtBaşarılı =mesaj;
                    return View();
                }
                else
                {
                    ViewBag.şifre2hatası = "Şifreler uyuşmuyor";
                    return View();
                }
            }
            else
            {
                return View();
            }

            return View();
        }

    }
}
