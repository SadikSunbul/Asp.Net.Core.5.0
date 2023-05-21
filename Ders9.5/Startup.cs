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

#region Asp.NET Core 5.0 - Secret Manager Tools �le Hassas Verilerin Korunmas�

//Web uygulamalar�nda devolopment ortam�nda kulland�g�mz baz� ver�ler�m�z� canl�ya deploy ed�lmes�n� �stem�yeb�l�r�z bu ver�ler:
/*
        -->Veri taban� bilgileri bar�nd�ran connection string bilgisi,
        -->Herhangi bir kritik arz eden token de�eri,
        -->Facebook veya google g�b� third party authentication i�lemleri yapmam�z� sagl�yan client secret id degerler vs.. olab�l�r

Bu veriler devoloper ortam�nda kullan�l�rken product�on ortam�nda kotu n�yetl� k�s�ler�n uygulama dosyalar�na er�s�m saglad�klar� drumlarda elde edemeyecekler� vaz�yette b�r sek�lde ez�lmeler� gerekmekted�r i�te bunun i�in secret Manger tool gel�st�r�lmst�r
 */

//Asp.net core uygulamalr�nda bu merkez genell�kler appsettings.json dosyas� olmaktad�r
//Bu dosya �cer�s�nde yaz�lan degeeler her ne olursa olsun uygulma publish ed�ld�g� takd�rde c�kt�dan er�s�leb�l� vaz�yette olacakt�r
//Dolay�s� �le b�zlere stat�c appsettings.json �cer�s�nde tutab�l�r�z lak�n arz eden ver�ler �c�n buras�n�n pekre ehemm�yetli b�r yer olmad�g� as�kard�r

//vericekme �slemler� ayn� d�r burad �lk once environment ta bakar sonra secret.json a bakar sonra appsettings.kjson a bakar ve ver�y� bulursa get�r�r �k�s�nde de ayn� deger varsa �lk tet�klenene gel�r 

#endregion