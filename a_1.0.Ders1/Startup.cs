using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a_1._0.Ders1
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {//uygulamaya modullerý ekleye býlgýmýz mýr modul

            // services.AddControllers(); //sadece kontroler
            services.AddControllersWithViews(); //hem kontroler hemde výev lerý uyguamya entegre edýyoruz
            //Asp.net core uygulamasýnda MVC mimarisini kullababýlmek ýcýn uygulamadan controller ve view ypýlandýrmanýn eklenmesý gerekmektedýr bunun ýcýn oncelýkle bu servýrs nu uygualmaya eklenýyor.Boylece uygulama mvc davranýsý sergýlemektedir
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//gelen ýstegýn rotasý bu mýdleware ýle belýrlenýr

            app.UseEndpoints(endpoints => //endpoint:Yapýlan ýstegýn varýs noktasý. URL.istek adresi
            //bu uygulamaya gelen ýsteklerýn hangý rotoda sablonda esliðinde gelebilecegini buradan býldýrcez
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapDefaultControllerRoute(); //varsayýlan rota istek rotasýný belýrtýr 

            });
        }
    }
}
