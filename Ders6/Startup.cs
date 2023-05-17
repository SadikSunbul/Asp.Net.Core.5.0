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
