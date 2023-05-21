using Ders9._4.appsettings.jsonDosyasıNedir.Models;
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

namespace Ders9._4.appsettings.jsonDosyasıNedir
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
            services.Configure<ilİnfo>(Configuration.GetSection("MailInfo")); //burada her yerde yaamıyalım dıye burada tutuk verıyı 
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

#region Asp.NET Core 5.0 - appsettings.json Dosyası Nedir? Ne İse Yarar?

//appsettings.json  dosyasu asp.net core uygulamalarında yapılandırma araclarından bırısıdır
//Yapılandırma bır uygulamanın herhangı bır ortamda gerceklestırecegı davranıslarını belırlememızı saglıyan statık degerın tanımlanmasıdır.

//Best practices acısından kodun ıcerısınde username ,Pasword .connectıon strıng vs. gıbı statık tanımlamalar yapılmamalıdır

//Asp.Net core de kı appsettıng.json dısındakı yapılandırma aracları nelerdır
//Appsettings.json | appsettings.{Environment}.json
//Secrets.json (secret Manager tools)
//Environment Variables
#endregion

#region Appsettings.json Konfigrasyonu

//Appsettıng.json yapısını eklemek gerekmez kendısı default olarak eklıdır 
//baska bı ısımle olursa onu .ConfigureAppConfiguration(x=>x.AddJsonFile("Sadik.json")) olarak eklersın

/*
 1->Nasıl veri eklenır?
2->Eklenen veri nasıl okunur ?
    ->IConfigration Arayüzü Nedir?
    ->Indexer ile veri okuma nasıl yapılır?
    ->GetSectiom Methodu ile veri okuma nasıl yapılır?
        ->Get Methoduyla verileri uygun nesneyle eslestırme
    -> : operatoru nedir?
 */
#endregion

#region Krıtık

//appsettings tum ortamlardan erısılebılır verıelr vardır burada 

//appsettings.Development sadece devoleper ortamında erısılebılır

//appsettings.Production sadece productıon ortamıda erısılır 

#endregion


#region Asp.NET Core 5.0 - Options Pattern İle Konfigürasyonları Dependency Injection ile Yapılandırma

#endregion
