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
