



using Ders9_Middleware.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders9_Middleware
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env) //m�ddleware burada tan�mlan�r 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();



            //app.Map("/Home/Privacy", builder =>
            //{
            //    builder.Use(async (context, task) =>
            //    {
            //        Console.WriteLine("Home start");
            //        await task.Invoke();
            //        Console.WriteLine("Home stop");
            //    });
            //});

            //app.Map("/Product/Index", builder =>
            //{
            //    builder.Run(async c =>
            //    {
            //        await c.Response.WriteAsync("Product ");
            //    });
            //});

        
            //app.Use(async (context, next) =>
            //{
            //     Console.WriteLine("Start use m�ddleware a");
            //    await next.Invoke(); //burada b� sonrak� metodu cag�r�r await �le beklemsek hata al�r�z
            //    Console.WriteLine("Stop Use M�dlevare a"); //sonrak� m�ddlewarelar b�tt�kten sonra buradan devam eder 
            //});

            //app.Run(async context =>
            //{
            //    Console.WriteLine("Run m�ddleware");
            //}); //buradan sonrak� m�dlewarelar� cal�st�rmaz 

            //app.MapWhen(c=>c.Request.Method=="GET",builder =>
            //{
            //    builder.Use(async (context, task) =>
            //    {
            //        await Console.Out.WriteLineAsync("Start Use Middleware2");
            //        await task.Invoke();
            //        await Console.Out.WriteLineAsync("Stop Use m�ddleware2");
            //    });
            //});
            app.UseHello();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization(); //kullan�c� yetk�ler�n� kontrol eder

            app.UseEndpoints(endpoints =>
            {



                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}

#region Middleware 

//Configure methodu �cer�snde middlewareler cagr�l�r 
//Asp.Net core m�mar�s�nde tumm middlewareler Use ad�yla baslarlar...
//Middlewarelerde tet�klenme s�ras� oneml�d�r 

//Haz�r m�ddlewareler:
/*
    run -->Kend�nden sonra gelen middleware y� tet�klemez Dolay�s� �le kullan�ld�g� yerden sonrak� m�ddleware y� tet�klem�yceg�nden dolay� ak�s kes�lcekt�r Bu etk�ye Short C�rcu�t(K�sa devre) den�r. pek kullan�lmaz
    use -->Run metoduna nazaran devreye g�rd�kten sonra surecte s�radak� m�ddleware� cag�rmakta ve normal middleware i�levi bittikten sonra ger�ye donup devam edeb�len b�r yapya sah�pt�r
    map -->Bazen m�ddleware � talep gonderen path e gore f�ltrelemek �st�yeb�l�r�z Bunun �c�n Use ya da Run fonks�yonlar�nda if kontrolu sa�l�yab�l�r yahut Map metodu �le daha profesyonel i�lem yapab�l�r�z cok s�k kullan�lmaz
    mapwhen -->Map methodu �le sadece request �n yap�ld�g� path e gore f�ltreleme yap�l�rken .MaphWhen methodu ile gelen request n herhang�b�r  ozell�g�ne gore f�ltreleme �slem� gerceklest�r�leb�l�r cok s�k kullan�lmaz
 */


#endregion

#region �zel m�ddleware olusturma 
/*
 1->B� klasor olsutur (M�ddlewares)
2-> HelloMiddleware.class oluturduk 
3-> burada bu yap� RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next=next;
        }
        public async Task Invoke(HttpContext context)
        {
            //custom operasyon 
            await Console.Out.WriteLineAsync("selam�n aleykum ");
            await _next.Invoke(context);
            await Console.Out.WriteLineAsync("Aleyk�m selam ");
        } olusturulur
4->Exens�ons klasorune extens�on class� ekeln�r
5-> yap�s� static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloMiddleware>();
        }
    }buna doner ve eklenm� olur app.UseHello(); olarak kullan�l�r
 */

#endregion