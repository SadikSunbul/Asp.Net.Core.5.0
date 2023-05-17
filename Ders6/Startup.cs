using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders6
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}

#region Asp.NET Core 5.0 - Mod�ler Tasar�m Yap�lanmas� Nedir? Nas�l Uygulan�r?

/*PartialView nedir?
Moduler tasar�mda her b�r modulun ayr� b�r cshtml olarak tasarlanmas�n� ve �ht�yac dogrultusunda �lg�l� parcan�n cagr�l�p kullan�lmas�n�sagl�yan b�r yontemd�r...
 
partal ver� gonderme:
normal gonderme yontemler� �le �lg�l� view w goner�p sank� viewde kullan�yormus cas�na �sted�g�n� part�al veyahut_Layout da kullan�lab�lr�

Partial classlardan @RenderSectiona deger gonder�lemez

 */


#endregion

#region Asp.NET Core 5.0 - ViewComponent Nedir? Nas�l Olu�turulur? Nas�l Kullan�l�r?
/*
 Part�al view �le ayn� ise yarar
 uret�lme amac� nedir: Part�al ver�y� -->Viewden al�r vievde --->Controlerdan al�r control�rda ---->Model den al�r ve contolur cok fazla �s� oldugu �c�n bosuna yorar�z o yuzden bunlar bulunustur ViewComponent d�rekt ver�y� Modeldan al�r

PartialView yap�lanmas� �ht�yac� olan datalar� controller uzer�nden elde edeceg� �c�n controller dak� mal�yet� art�rmakta ve SOLID per�ns�pler�ne ayk�r� davran�s�na sebeb�yet vereb�lmekted�r...
PartialView yap�sal olarak controler uzer�nden beslenmektedir

ViewComponent �ht�yac� olan datalr� controller uzer�nden deg�lde d�rekt kend�  cs dosyas�ndan elde edebilmektedir.Boylece controllerdak� luzumsuz mal�yet ortadan kald�r�lm�s olmaktay�z....
 */
#endregion
