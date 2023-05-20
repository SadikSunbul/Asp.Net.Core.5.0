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
            services.AddAutoMapper(typeof(PersonelProfils)); //NuGet\Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 12.0.1 �nmel� 
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

//ViewModel temelde �k� farkl� senaryoda kars�l�k sorumluluk ustlenen ve b�z yaz�l�m gel�st�r�c�ler�n�n �s�n� kolaylast�ran operasyonel nesnelerd�r

//1.Senaryo : OOP yap�lanmas�nda b�r model�n kullan�c� �le etk�les�m� net�ces�nde kullan�lan ve esas datan�n memberlar�n� tems�l eden ve s�re�te ilgili model yerine veri ta��ma transfer operasyonu �stlenen bir nesnedir.

//2.Senaryo :Birden fazla model� deger� ver�y� tek b�r nesne uzer�nden b�rlest�rme gorev� goren nesned�r

#endregion

#region DTO Nedir?

//DTO (Data Transfer Object)
//Herhang� b�r davran�s� olmayan ve uygulaman�n ces�tl� yerler�nde yaln�zca b�r ver� tuket�m� ve �let�m� �c�n kullan�lan ver�taban�ndak� herhang� b�r ver�n�n transfer nesnes�ndir kars�l�g�d�r gorunumudur

//view sunum yapmak �c�n kullan�l�r dto hem backende ver� tas�mada hemde sunumda kullan�lab�l�r
//view model �cer�s�nde fank bar�nd�ra b�l�yor dto bar�nd�rm�yor


#endregion

#region S�zle�me Kontrant Mant�g� Nedir?

//Backend de uret�len b�r ver�n�n cl�nta gonder�lmes� �c�n tasarlanan ViewModel o i�lemin sozle�mesi kontrat� olmaktad�r
//Haliyle Backend den gelecek datay� client �n uygun formatta kars�layab�lmesi icin kes�nl�kle o tureden b�r nesne olusturmasu gerekecekt�r

#endregion

#region ViewModel larda Val�dat�on Durumlar� 
//Kullan�c�dan al�nan ver�ler �s kural� gereg� kontrol ed�l�rler b�zler bu kontrollere val�dat�on d�yoruz

//kullan�c�lardan gelen ver�ler kes�nl�kle ver� taban� tablolar�n�n kars�l�g� olan ent�ty modelleri olmal�d�r! ViewModel olarak al�nmal�d�r ! ve tum val�dat�onlar bu viewModel nesneler� user�nden gerceklest�r�lmel�d�r
#endregion

#region ViewModel � Ent�ty Model e Donusturme

//Kullan�c�dan gelen datalar� ViewModel �le kars�lad�ktan sonra bu viewmodel da k� ver�ler� ver�taban�na kaydetmek �st�yeb�l�r�z bu durumda bu ver�ler� ent�ty model e donusturmem�z gerekecekt�r bunun �c�n asag�dak� yontemlerden herhang� b�r� kullan�lab�l�r 

//Manuel Donusturme
//Implict operator Overload ile Donusturme
//Explict Operator Overload ile D�nusturme
//Reflection ile Donusturme 
//AutoMapper Kutuphanes� �le donusturme 



#endregion