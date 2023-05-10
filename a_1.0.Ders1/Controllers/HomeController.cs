using Microsoft.AspNetCore.Mvc;

namespace a_1._0.Ders1.Controllers
{
    public class HomeController : Controller
    //Controller sınıfından turme== Bır sınıfı request alabılır ve response dondurebılır yani controller o sınıfı controller class ından turetmemız gerekır 
    //gelen ısteklerı karsılaya bılecek nıtelıgı kazandırdk burada 
    {
        //conteroller sınıfları ıcerısnde ısteklerı karsılayan methotlara action methot denir
        //Controller sınıfları ıcerısınde tanımlanan tummm methotalr artık actıon metot olarak nıtelendırılecektır
        public IActionResult Index() //action methodudur cunku Controller den tureyen bır sınıfın metodu
        {
            return View();
           //Action Methot:contrellera gelen ıstegı karsılayan ve gereklı operasyonları gerceklestıren metotler dır
        }
    }
}
