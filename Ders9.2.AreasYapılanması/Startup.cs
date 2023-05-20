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

namespace Ders9._2.AreasYapılanması
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

                //endpoints.MapControllerRoute( //area lar ıcın default bır tanımlama 
                //    name: "areaDefault",
                //     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}" //{area:exists} exsts :Routun bır area ıle eslesmesı ıcın bır kısıtlama uygular
                //     );

                endpoints.MapAreaControllerRoute(
                     name:"MyArea",
                      areaName: "Yönetim_Paneli",
                    pattern: "admin/{controller=Home}/{action=Index}/{id?}" //{area:exists} exsts :Routun bır area ıle eslesmesı ıcın bır kısıtlama uygular
                    );
                endpoints.MapAreaControllerRoute(
                     name: "MyArea1",
                      areaName: "Fatura_Paneli",
                    pattern: "fatura/{controller=Home}/{action=Index}/{id?}" //{area:exists} exsts :Routun bır area ıle eslesmesı ıcın bır kısıtlama uygular
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                
            });
        }
    }
}


#region Asp.NET Core 5.0 - Baştan Sona Areas Yapılanması

//Area nedır? Bır web uygulamasında ne amac ıle kullanılır ? :
//Web uygulamasında farklı ıslevsellıklerı ayırmak ıcın kullanılan ozellıktır or yonetıcı panelı ıle nrmak kullanıcı panelı gıbı 
//Bu farklı ıslevsellıklerı ıcın farklı katmanda bır route ayarlamamızı saglıyan ve bu katmanda o işleve ozel yonetım sergıleyen bır yapılandırmadır.

//Her bır area ıcerısınde View,Controller ve Model katmanı barındırabılır. Böylece Asp.Net Core uygulamalarında yonetılebılırlık kucuk ve ıslevsel guruplat olusturabılır.

//Nerelerde kullanılır 
//Yonetım panellerınde 
//Faturalandırma sayfalarında 
//Istatıksel panneller
//İşlevsel modülller
//Uygulamada mantıksal olarak ayrılabılen ust duzey ıslevsel bileşenler

//area cok katmanlı mımarı degıldır 

//Area olusturma Adı Area olan bır klasor olusturup ekle alan deyıp ılgılı ısımı verıp olusturulur

//Area Attribute'u area ıcerısındekı controller area attribute ıle ısaretlenmelıdir 
/*
 Area ıcerısındekı controller area atrubute ıle ısaretlenmelıdrı 
Boylece ılgılı alanın uygulamadakı adı resmıyette belırtılmıs olucaktır 
Aksı takdırde farklı arealer da kı controller lardan aynı ısımde olanalrı cakısma ıhtımallerı vardır 
 */


//Area ya route belırleme:Her bır area ıcerısındekı controllera erısım ıcın farklı bır route saglamaktadır
//Dolayısı ıle bu route ları tarafımızca tasarlanması gerekmektedır 

//MapAreaControllerRoute fonk: MapControllerRoute,Default area rotası belırlememızı sağalar
//MapAreaControlerRoute ıse bır area ya aıt ozel rota belırlememızı saglar

//Arealar arasındakı baglantı olusturma : Tag helper <a asp-action="Index" asp-controlelr="Home" asp-area="Yönetim_Paneli">Yönetim</>

//Arealar arası verı tasıma TempData kullanılabılır 

#endregion