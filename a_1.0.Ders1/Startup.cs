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
        {//uygulamaya moduller� ekleye b�lg�m�z m�r modul

            // services.AddControllers(); //sadece kontroler
            services.AddControllersWithViews(); //hem kontroler hemde v�ev ler� uyguamya entegre ed�yoruz
            //Asp.net core uygulamas�nda MVC mimarisini kullabab�lmek �c�n uygulamadan controller ve view yp�land�rman�n eklenmes� gerekmekted�r bunun �c�n oncel�kle bu serv�rs nu uygualmaya eklen�yor.Boylece uygulama mvc davran�s� serg�lemektedir
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//gelen �steg�n rotas� bu m�dleware �le bel�rlen�r

            app.UseEndpoints(endpoints => //endpoint:Yap�lan �steg�n var�s noktas�. URL.istek adresi
            //bu uygulamaya gelen �stekler�n hang� rotoda sablonda esli�inde gelebilecegini buradan b�ld�rcez
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapDefaultControllerRoute(); //varsay�lan rota istek rotas�n� bel�rt�r 

            });
        }
    }
}
