using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders9._5_
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ders9._5_", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ders9._5_ v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

#region Asp.NET Core 5.0 - Secret Manager Tools Ýle Hassas Verilerin Korunmasý

//Web uygulamalarýnda devolopment ortamýnda kullandýgýmz bazý verýlerýmýzý canlýya deploy edýlmesýný ýstemýyebýlýrýz bu verýler:
/*
        -->Veri tabaný bilgileri barýndýran connection string bilgisi,
        -->Herhangi bir kritik arz eden token deðeri,
        -->Facebook veya google gýbý third party authentication iþlemleri yapmamýzý saglýyan client secret id degerler vs.. olabýlýr

Bu veriler devoloper ortamýnda kullanýlýrken productýon ortamýnda kotu nýyetlý kýsýlerýn uygulama dosyalarýna erýsým sagladýklarý drumlarda elde edemeyeceklerý vazýyette býr sekýlde ezýlmelerý gerekmektedýr iþte bunun için secret Manger tool gelýstýrýlmstýr
 */

//Asp.net core uygulamalrýnda bu merkez genellýkler appsettings.json dosyasý olmaktadýr
//Bu dosya ýcerýsýnde yazýlan degeeler her ne olursa olsun uygulma publish edýldýgý takdýrde cýktýdan erýsýlebýlý vazýyette olacaktýr
//Dolayýsý ýle býzlere statýc appsettings.json ýcerýsýnde tutabýlýrýz lakýn arz eden verýler ýcýn burasýnýn pekre ehemmýyetli býr yer olmadýgý asýkardýr

//vericekme ýslemlerý ayný dýr burad ýlk once environment ta bakar sonra secret.json a bakar sonra appsettings.kjson a bakar ve verýyý bulursa getýrýr ýkýsýnde de ayný deger varsa ýlk tetýklenene gelýr 

#endregion