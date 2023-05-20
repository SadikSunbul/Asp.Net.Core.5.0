using Ders8_OzellestırılmısResponsKarsılama.Handlers;
using Ders8_OzellestırılmısResponsKarsılama.Hendlers;
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

namespace Ders8_OzellestırılmısResponsKarsılama
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
                //endpoints.Map("example-route",async c =>
                //{
                //    //https://localhost:5000/example-roote endpoıntıne gelen herhangı bır ıstek controller dan ziyade drekt olarak buradakı fonksıyondan tarafından karsılanacaktır 
                //});
                endpoints.Map("image/{filename}", new ImageHandler().Handler(env.WebRootPath));
                endpoints.Map("example-route",new ExampleHandler().Handler()); //ustekı ıle aynı sey
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

#region asp.NET Core 5.0 - Custom Route Handler Nedir? Nasıl İnşa Edilir?

//Custom Route Handler : Herhangı bır belırlenmıs route semasının controller sınıflarından ziyade busnies mantıgında karsılanması ve orada is gorup responsueun donulmesı operasyonudur.

//genel gecer operasyonlarda klasık controller mekanızmasıyla geln requesti karsılayıp gereklı operasyonu gerceklestıreceksın 



#endregion