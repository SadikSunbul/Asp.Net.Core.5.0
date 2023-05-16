using ders4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ders4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Asp.NET Core 5.0 - Kullanıcıdan Gelen Verilerin Doğrulanması Validations
        //Validations nedir:Bir degerın ıcınde bulundugu sartlara uygun olması durumudur.Belirlenen kosullara ve amaca uygun olup olmama durumunun kontrol edılmesıdır.gelen verılerın dogru bır verı olması dogrulanması gerekır bunları ayırt etmemızı saglıyan yapılardır
        //Bu kontrole gore verırının ısleme tabı tutlması durumudur 
        //Valıdatıon Paralel bır sekılde clıent ve server tarafında uygulanmalidir ...
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {       //Malıyetlı  
            //if(!string.IsNullOrEmpty(model.ProductName)&&model.ProductName.Length<=100&&model.Email)
            //{

            //}
            //Valıdatıonları ılgılı classın propertylerınde yapıcaz
            //ModelState:Mvc de bır type ın annotationslarının durumunu kontrol eden ve geriye sonuc donen bır propertydır.
            if (ModelState.IsValid) //dogruladıysan 
            {
                //işlem operasyon algorıtmaya tabı tutulur
            }
            else
            {
                //loglama 
                //kullanıcı bılgılendırmeler
                //ViewBag.Hata = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;
                //var data = ModelState.Values.Where(x=>x.ValidationState==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).ToList();
                //var mesage=data[0].Errors[0].ErrorMessage;

                //hataları dırekt olarak html ıcerısınde yakalıyoruz bunun ıcın gelen model ı drekt gondermemız gerekır
                var message = ModelState.ToList();

                return View(model);
            }



            return View();
        }
        #endregion
    }
}

#region Asp.NET Core 5.0 - Server’da ki Validation’ları Dinamik Olarak Client Tabanlı Uygulamak
//bunları wwwroot klasoru olustuturp oraya yuklemem gerkır sonra Configure ye app.UseStaticFiles(); eklenmelıdır dosya ustunden sol tıkla ekle-->İstemcı tarafı kıtaplıgı 
//jquery
//jquery-validate
//jquery-validation-unobtrusive 
//bunların ındırımesı gerekrı gereklı klasore 
//sonra nerede valıdatıon yapıcaksak o viewe bu kutuphaneler eklenmelıdır mın klasorunu surukle
//anlık olarak maıle uyuyormu kontrollerı yapmayı saglar 
#endregion