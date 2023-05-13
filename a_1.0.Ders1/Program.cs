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

//Helpers nedir: Yard�mc�lar demekt�r 
//UrlHelper:Asp.Net Core MVC uygulmalar�nda url olusturmak �c�n yard�mc� metotlar �cereen ve o anki url'e da�r b�zlere b�lg� veren b�r s�n�ft�r
/*
 UrlHelper b�ze saglad�g�

*****Methotalr******
->Action:Verilen Controller ve Act�ona da�r url olustumay� saglayan metottur or:{Url.Action("index","product",new {id=5})} c�kt�:/product/index/5
->ActionLink:Veerilen Controller ve act�on ait url olusturmat� sagalyan metotur or:{Url.Action("index","product",new {id=5})} c�kt�:https://localhosy5001/product/index/5 
->Content:Genellikle css ve script g�b� dosya d�z�nler�n� programat�k olaraktar�f etmek �c�n kullanmaktay�z orn:Url.Content("~/site.css") pek efekt�f deg�l cunku yen� b�sey var UseStaticFiles middleware ile geldi
->RouterUrl:Mimaride tan�ml� olan Route �s�mler�ne uygun b�r sek�lde url olusturan b�r metot orn:Url.RouteUrl("Default")

*****Propertyler *****
*->ActionContext:O ank� url e da�r tum b�lg�lere er�seb�lmem�z� saglayan b�r property d�r 
 */

//HtmlHelper
/*
 cok mal�yetl� buras� pek  kullanmay�z tagler daha az mal�yetl�d�r
Html et�ketler�n� server tabanl� olusturmamm�z� saglayan sozde yard�mc� methotlar� bar�nd�rmaktad�r
Hedeflenen .cshtml dosyalar�n render etmem�z� saglamaktad�r
O ank� contexe da�r b�lg�ler ed�nmem�z� saglar
ver� tas�ma kontroller�ne er�s�mem�z� saglar

*****Methotalr******
->Html.Partial : Hedef viewi render etmem�z� saglayan b�r fonkdur  orn:@html.Partial("~/Views/Product/Index.cshtml") gibi render ed�len viewe ilgilki actiondan model data gondereb�lmekted�r string doner
->Html.RenderPartial: hedef Viewin render etmem�z� sagl�yan b�r fonktur vo�d doner parantezler �ecer�s�nde yaz�lmal�d�r @{html.RenderPartial("~/Views/Product/Index.cshtml");}  i�levsel olarak deg�s�kl�k yoktur bu daha h�zl�d�r genelde bunu terc�h ed�cez
->Html.ActionLink: Url olusturur @Html.ActionLink("Anasayfa","Index","Home")
->Html Form methotlar�:Kullan�c� �le etk�les�me g�rmem�z� sagl�yan form ve input nesneleri olusturmam�z� sagl�yan metotlard�r (BeginForm,CheckBox,TxtBox,Display,Password,TextArea,ValidationMessage) maliyetl�d�r genelde kullanm�ycaz yan� tag halper �le yap�caz bunlar� 

******Propertyler *****
->viewContext
->TempData
->ViewData
->ViewBag
 */

#region TagHelper --> cok kullan�caz
//nedir: daha okunab�l�r anlas�lab�l�r ve kolay gel�st�r�leb�l�r bir view in�a etmemizi ssa�layan Ap.Net Core ile b�rl�kte HtmlHelpers lar�n yer�ne gelen yap�lard�r
//kod mal�yet�n� dusurmekted�r
//htmlhelperslar�n html nesneler�n�n generete ed�lmes�n� servera yuklenmes�n�n get�rd�g� mal�yet�de ortadan kald�rmaktad�rlar


#endregion


