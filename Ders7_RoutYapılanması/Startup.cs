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

namespace Ders7_RoutYapılanması
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
                endpoints.MapControllerRoute("Default4", "{controller}/{action}/{id:int?}/{x?}/{y?}");// home/ındex/54/ahmet/3.20 hepsı olur tur onemlı degıldır burada   -->{id:int?} id turu ınt olucak ve nulublede olabılrı  burada sayısal degerlerde ınt kullanıcaz dıger degerlerde hata verebılıyor strıg ıfadelerde de yazmaya gerek yok hersey ztn strınge dondurule bılıyor
                endpoints.MapControllerRoute("Default3","anasayfa",new {controller="Home",action="Index"}); //burada lınklere bakar ve bu tarza uyan actıonu ındex ve controller ı home olanı anasayfa olarak adlandırır
                // url yerınde https://localhost:5001/anasayfa dersek bu soyle calısır --_>https://localhost:5001/Home/Index  burada bunu tanımlamasını yapmıs olduk 
                /*endpoints.MapControllerRoute("Default2", "{controller=Personel}/sadık/{action=Index}");*/  //hatalı url olur mantıklı kur 
                //endpoints.MapControllerRoute("Default1","{action}/ahmet/controller");  //--->    Index/ahmet/Home
                endpoints.MapDefaultControllerRoute();

                //Birdenn fazla rout yapılanması tanımlıycaksan ozelden genle dogru bır sıralama yapmamız gerekir ılk ozellere uyuyormu onun kontrlu yapılsın en son default u kontrol etsın bu rotoların ısmıde unıq olmalı aynı ısımlı olmazlar 

            });
        }
    }
}

#region Route
//Route:Gelecek olan ıstegın hangı rotaya gıdecegını belırleyen sablonlardır
#endregion
