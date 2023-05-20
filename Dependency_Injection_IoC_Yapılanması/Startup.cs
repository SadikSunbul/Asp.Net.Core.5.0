using Dependency_Injection_IoC_Yapılanması.Controllers.Services;
using Dependency_Injection_IoC_Yapılanması.Controllers.Services.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_IoC_Yapılanması
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //burada .net hazır bır contaıner vermıs bıze 
        {
            //add ıle eklenıyorsa default olraka Singleton dır 
            //services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog())); //contaınera ekleme yaptık
            //services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));  //ServiceLifetime.Transient nasıl alıscagınıda belırte bılrıız boyle

            /*           IoC             */
            /*  services.AddSingleton<ConsoleLog>();*/ //ustekıler ıle aynı ısı yapar
                                                       //services.AddSingleton<ConsoleLog>(p=>new ConsoleLog(5)); //ctor da parametre varsa boyle olusturcaksın 

            //services.AddScoped<ConsoleLog>();
            //services.AddScoped<ConsoleLog>(p => new ConsoleLog(5));

            //services.AddTransient<ConsoleLog>();
            //services.AddTransient<ConsoleLog>(p => new ConsoleLog(5));

            //services.AddScoped<ILog>(p=>new ConsoleLog(5)); //burada cagırıken artık ILog turunden cagırmamız gerkeıcek 
            //services.AddScoped<ILog>(p=>new TextLog()); //gun gelır degısıklık yapılmak ıstenırse buradan textlog yazamak yeterldıerı 
            services.AddScoped<ILog, TextLog>(); //bi ustekı ıle aynıdır 
            //services.AddScoped<ILog, ConsoleLog>(p=>new ConsoleLog(5)); 

            services.AddControllersWithViews();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

#region Asp.NET Core 5.0 - Dependency Injection - IoC Yapılanması

//Yani temel olarak olusturulan bır class ıcerısınde baska bır sınıfın nesnesını new anahtar socuguyle olusturulmasını soyleyen bır yaklasımdır Dependency Injection
//Dependency Injection : Bagımlılıkları soyutlamak demek

//IoC nedir?: Sınıfların bagımlılıgını azltmak ıcın bagımlılıkları dependency Indectıon ıle dısarıdan alabılırız demıstık Ancak bazı durumlarda sınıfımız ıcerısınde cok sayıda arayuze referans vermemız gerekebılır. Bu durumda her bırı cın dependency ınjectıon kodu yazmamız gerekecektır kı bu durum sonunda bır kod karmasasuna neden olacaktır bunun ıcın bu ızlemın otomatıklestırermek gerekır
//IoC calısma mantıgı : Dependency Injectıon kullanılarak enjecte edılecek olan tum degerler nesneler IoC Contaıner dedıgımız bır sınıfta tutulurlar. Ve ıhtıyac dogrultusunda bu degerler nesneler cagrılarak elde edılırler

//.Net uygulamalarında IoC yapılanmasını saglıyan thırd party freameworkler mevcuttur 
/*
        Structuremap
        AutoFac
        Ninject
 */
//Built-in IoC Contaıner ıcerısıne koyulacak degerı nesnelerı uc farklı davranısla alabılmektedır 

/*
 
 Davranıs 1->Singleton :Uygulama bazlı tekıl nesne olusturur.Tum taleplere o nesneyı gonderır.

Davranıs 2->Scoped :Her request basına bır nesne uretır ve o request pıpeline nında olan tum ısteklere o nesneyı gonderır

Davranıs 3->Transient : Her request ın her talebıne karsılık bır nesne uretır ve gonderır 
 */

#endregion
