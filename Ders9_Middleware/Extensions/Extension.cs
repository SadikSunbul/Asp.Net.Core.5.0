using Ders9_Middleware.Middelewares;
using Microsoft.AspNetCore.Builder;

namespace Ders9_Middleware.Extensions
{
   static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloMiddleware>();
        }
    }
}
