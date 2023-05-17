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

#region Asp.NET Core 5.0 - Modüler Tasarým Yapýlanmasý Nedir? Nasýl Uygulanýr?

/*PartialView nedir?
Moduler tasarýmda her býr modulun ayrý býr cshtml olarak tasarlanmasýný ve ýhtýyac dogrultusunda ýlgýlý parcanýn cagrýlýp kullanýlmasýnýsaglýyan býr yontemdýr...
 
partal verý gonderme:
normal gonderme yontemlerý ýle ýlgýlý view w gonerýp sanký viewde kullanýyormus casýna ýstedýgýný partýal veyahut_Layout da kullanýlabýlrý

Partial classlardan @RenderSectiona deger gonderýlemez

 */


#endregion

#region Asp.NET Core 5.0 - ViewComponent Nedir? Nasýl Oluþturulur? Nasýl Kullanýlýr?
/*
 Partýal view ýle ayný ise yarar
 uretýlme amacý nedir: Partýal verýyý -->Viewden alýr vievde --->Controlerdan alýr controlýrda ---->Model den alýr ve contolur cok fazla ýsý oldugu ýcýn bosuna yorarýz o yuzden bunlar bulunustur ViewComponent dýrekt verýyý Modeldan alýr

PartialView yapýlanmasý ýhtýyacý olan datalarý controller uzerýnden elde edecegý ýcýn controller daký malýyetý artýrmakta ve SOLID perýnsýplerýne aykýrý davranýsýna sebebýyet verebýlmektedýr...
PartialView yapýsal olarak controler uzerýnden beslenmektedir

ViewComponent ýhtýyacý olan datalrý controller uzerýnden degýlde dýrekt kendý  cs dosyasýndan elde edebilmektedir.Boylece controllerdaký luzumsuz malýyet ortadan kaldýrýlmýs olmaktayýz....
 */
#endregion
