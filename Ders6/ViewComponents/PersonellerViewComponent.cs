
using Ders6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ders6.ViewComponents
{
    public class PersonellerViewComponent:ViewComponent
    {
        //[NonViewComponent] buradsı vıewcomponent degıl demıs olduk burada 
        public IViewComponentResult Invoke(int id) //Tasarlanan viewcomponent cagrılıp render edıldıgınde ıcerısınde calısmasını ıstedıgımız kodların bu ımzada bır metodun ıcerısıne yerlestırmelıyız ısmı boyle olucak farklı bı ısım olursa calısmaz
        {
            //(int id)  id degerınde dıger taraftan gelen verıyı yakalıya bılıyoruz
            List<Personel> data = new List<Personel>
            {
                new Personel{Adi="Sadık",Soyadı="Sünbül"},
                new Personel{Adi="Hasan",Soyadı="Sünbül"},
                new Personel{Adi="Rıfkı",Soyadı="Yılmaz"},
                new Personel{Adi="Taha",Soyadı="Corumlu"},
            };
            return View(data);
        }

        /*
         Buradakı view ı arıyacagı yer ılgılı kullanıldıgı controler ısmının vıew dosyasının ıcerısınde Companents onunda ıcerısınde kendı clas ısmın arar( Personeller) bunun ınde Default dersenız drekt onu acar farklı bı ısım verırısenız View(...) demek gerekir
         */
        /*
         Genelde kullanıcagımız yer Shared ıcerısınde Componnets Onunda ıcerısınde Ilgılı calss ısmı (Personeller) onunda ıcerısınde Default -->View() veya Ahe-->View("Ahmet") demke gerekır 
         */
        /*
         critikler:
        burada sadece gets seklınde calısmakta bır post alamaz burası ısteklerı karsılamaz yanı burası 
        burada bı form tasarladıysanı bunu ilgili controlra yonlendırmek gerekır 
         */
    }
}
