



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
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env) //mýddleware burada tanýmlanýr 
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
            //     Console.WriteLine("Start use mýddleware a");
            //    await next.Invoke(); //burada bý sonraký metodu cagýrýr await ýle beklemsek hata alýrýz
            //    Console.WriteLine("Stop Use Mýdlevare a"); //sonraký mýddlewarelar býttýkten sonra buradan devam eder 
            //});

            //app.Run(async context =>
            //{
            //    Console.WriteLine("Run mýddleware");
            //}); //buradan sonraký mýdlewarelarý calýstýrmaz 

            //app.MapWhen(c=>c.Request.Method=="GET",builder =>
            //{
            //    builder.Use(async (context, task) =>
            //    {
            //        await Console.Out.WriteLineAsync("Start Use Middleware2");
            //        await task.Invoke();
            //        await Console.Out.WriteLineAsync("Stop Use mýddleware2");
            //    });
            //});
            app.UseHello();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization(); //kullanýcý yetkýlerýný kontrol eder

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

//Configure methodu ýcerýsnde middlewareler cagrýlýr 
//Asp.Net core mýmarýsýnde tumm middlewareler Use adýyla baslarlar...
//Middlewarelerde tetýklenme sýrasý onemlýdýr 

//Hazýr mýddlewareler:
/*
    run -->Kendýnden sonra gelen middleware yý tetýklemez Dolayýsý ýle kullanýldýgý yerden sonraký mýddleware yý tetýklemýycegýnden dolayý akýs kesýlcektýr Bu etkýye Short Cýrcuýt(Kýsa devre) denýr. pek kullanýlmaz
    use -->Run metoduna nazaran devreye gýrdýkten sonra surecte sýradaký mýddlewareý cagýrmakta ve normal middleware iþlevi bittikten sonra gerýye donup devam edebýlen býr yapya sahýptýr
    map -->Bazen mýddleware ý talep gonderen path e gore fýltrelemek ýstýyebýlýrýz Bunun ýcýn Use ya da Run fonksýyonlarýnda if kontrolu saðlýyabýlýr yahut Map metodu ýle daha profesyonel iþlem yapabýlýrýz cok sýk kullanýlmaz
    mapwhen -->Map methodu ýle sadece request ýn yapýldýgý path e gore fýltreleme yapýlýrken .MaphWhen methodu ile gelen request n herhangýbýr  ozellýgýne gore fýltreleme ýslemý gerceklestýrýlebýlýr cok sýk kullanýlmaz
 */


#endregion

#region Özel mýddleware olusturma 
/*
 1->Bý klasor olsutur (Mýddlewares)
2-> HelloMiddleware.class oluturduk 
3-> burada bu yapý RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next=next;
        }
        public async Task Invoke(HttpContext context)
        {
            //custom operasyon 
            await Console.Out.WriteLineAsync("selamýn aleykum ");
            await _next.Invoke(context);
            await Console.Out.WriteLineAsync("Aleyküm selam ");
        } olusturulur
4->Exensýons klasorune extensýon classý ekelnýr
5-> yapýsý static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloMiddleware>();
        }
    }buna doner ve eklenmý olur app.UseHello(); olarak kullanýlýr
 */

#endregion