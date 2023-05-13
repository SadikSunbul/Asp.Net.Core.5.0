using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a_1._0.Ders1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

//Helpers nedir: Yardýmcýlar demektýr 
//UrlHelper:Asp.Net Core MVC uygulmalarýnda url olusturmak ýcýn yardýmcý metotlar ýcereen ve o anki url'e daýr býzlere býlgý veren býr sýnýftýr
/*
 UrlHelper býze sagladýgý

*****Methotalr******
->Action:Verilen Controller ve Actýona daýr url olustumayý saglayan metottur or:{Url.Action("index","product",new {id=5})} cýktý:/product/index/5
->ActionLink:Veerilen Controller ve actýon ait url olusturmatý sagalyan metotur or:{Url.Action("index","product",new {id=5})} cýktý:https://localhosy5001/product/index/5 
->Content:Genellikle css ve script gýbý dosya dýzýnlerýný programatýk olaraktarýf etmek ýcýn kullanmaktayýz orn:Url.Content("~/site.css") pek efektýf degýl cunku yený býsey var UseStaticFiles middleware ile geldi
->RouterUrl:Mimaride tanýmlý olan Route ýsýmlerýne uygun býr sekýlde url olusturan býr metot orn:Url.RouteUrl("Default")

*****Propertyler *****
*->ActionContext:O anký url e daýr tum býlgýlere erýsebýlmemýzý saglayan býr property dýr 
 */

//HtmlHelper
/*
 cok malýyetlý burasý pek  kullanmayýz tagler daha az malýyetlýdýr
Html etýketlerýný server tabanlý olusturmammýzý saglayan sozde yardýmcý methotlarý barýndýrmaktadýr
Hedeflenen .cshtml dosyalarýn render etmemýzý saglamaktadýr
O anký contexe daýr býlgýler edýnmemýzý saglar
verý tasýma kontrollerýne erýsýmemýzý saglar

*****Methotalr******
->Html.Partial : Hedef viewi render etmemýzý saglayan býr fonkdur  orn:@html.Partial("~/Views/Product/Index.cshtml") gibi render edýlen viewe ilgilki actiondan model data gonderebýlmektedýr string doner
->Html.RenderPartial: hedef Viewin render etmemýzý saglýyan býr fonktur voýd doner parantezler ýecerýsýnde yazýlmalýdýr @{html.RenderPartial("~/Views/Product/Index.cshtml");}  iþlevsel olarak degýsýklýk yoktur bu daha hýzlýdýr genelde bunu tercýh edýcez
->Html.ActionLink: Url olusturur @Html.ActionLink("Anasayfa","Index","Home")
->Html Form methotlarý:Kullanýcý ýle etkýlesýme gýrmemýzý saglýyan form ve input nesneleri olusturmamýzý saglýyan metotlardýr (BeginForm,CheckBox,TxtBox,Display,Password,TextArea,ValidationMessage) maliyetlýdýr genelde kullanmýycaz yaný tag halper ýle yapýcaz bunlarý 

******Propertyler *****
->viewContext
->TempData
->ViewData
->ViewBag
 */

#region TagHelper --> cok kullanýcaz
//nedir: daha okunabýlýr anlasýlabýlýr ve kolay gelýstýrýlebýlýr bir view inþa etmemizi ssaðlayan Ap.Net Core ile býrlýkte HtmlHelpers larýn yerýne gelen yapýlardýr
//kod malýyetýný dusurmektedýr
//htmlhelperslarýn html nesnelerýnýn generete edýlmesýný servera yuklenmesýnýn getýrdýgý malýyetýde ortadan kaldýrmaktadýrlar


#endregion


