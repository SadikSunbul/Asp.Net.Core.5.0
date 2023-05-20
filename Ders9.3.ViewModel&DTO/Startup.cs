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
using FluentValidation;
using FluentValidation.AspNetCore;
using Ders9._3.ViewModel_DTO.AutoMappers;

namespace Ders9._3.ViewModel_DTO
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
            services.AddAutoMapper(typeof(PersonelProfils)); //NuGet\Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 12.0.1 ýnmelý 
            services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Startup>());
            
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


#region ViewModel 

//ViewModel temelde ýký farklý senaryoda karsýlýk sorumluluk ustlenen ve býz yazýlým gelýstýrýcýlerýnýn ýsýný kolaylastýran operasyonel nesnelerdýr

//1.Senaryo : OOP yapýlanmasýnda býr modelýn kullanýcý ýle etkýlesýmý netýcesýnde kullanýlan ve esas datanýn memberlarýný temsýl eden ve süreçte ilgili model yerine veri taþýma transfer operasyonu üstlenen bir nesnedir.

//2.Senaryo :Birden fazla modelý degerý verýyý tek býr nesne uzerýnden býrlestýrme gorevý goren nesnedýr

#endregion

#region DTO Nedir?

//DTO (Data Transfer Object)
//Herhangý býr davranýsý olmayan ve uygulamanýn cesýtlý yerlerýnde yalnýzca býr verý tuketýmý ve ýletýmý ýcýn kullanýlan verýtabanýndaký herhangý býr verýnýn transfer nesnesýndir karsýlýgýdýr gorunumudur

//view sunum yapmak ýcýn kullanýlýr dto hem backende verý tasýmada hemde sunumda kullanýlabýlýr
//view model ýcerýsýnde fank barýndýra býlýyor dto barýndýrmýyor


#endregion

#region Sözleþme Kontrant Mantýgý Nedir?

//Backend de uretýlen býr verýnýn clýnta gonderýlmesý ýcýn tasarlanan ViewModel o iþlemin sozleþmesi kontratý olmaktadýr
//Haliyle Backend den gelecek datayý client ýn uygun formatta karsýlayabýlmesi icin kesýnlýkle o tureden býr nesne olusturmasu gerekecektýr

#endregion

#region ViewModel larda Valýdatýon Durumlarý 
//Kullanýcýdan alýnan verýler ýs kuralý geregý kontrol edýlýrler býzler bu kontrollere valýdatýon dýyoruz

//kullanýcýlardan gelen verýler kesýnlýkle verý tabaný tablolarýnýn karsýlýgý olan entýty modelleri olmalýdýr! ViewModel olarak alýnmalýdýr ! ve tum valýdatýonlar bu viewModel nesnelerý userýnden gerceklestýrýlmelýdýr
#endregion

#region ViewModel ý Entýty Model e Donusturme

//Kullanýcýdan gelen datalarý ViewModel ýle karsýladýktan sonra bu viewmodel da ký verýlerý verýtabanýna kaydetmek ýstýyebýlýrýz bu durumda bu verýlerý entýty model e donusturmemýz gerekecektýr bunun ýcýn asagýdaký yontemlerden herhangý býrý kullanýlabýlýr 

//Manuel Donusturme
//Implict operator Overload ile Donusturme
//Explict Operator Overload ile Dönusturme
//Reflection ile Donusturme 
//AutoMapper Kutuphanesý ýle donusturme 



#endregion