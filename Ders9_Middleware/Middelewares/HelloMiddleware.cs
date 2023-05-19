using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Ders9_Middleware.Middelewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next=next;
        }
        public async Task Invoke(HttpContext context)
        {
            //custom operasyon 
            await Console.Out.WriteLineAsync("selamın aleykum ");
            await _next.Invoke(context);
            await Console.Out.WriteLineAsync("Aleyküm selam ");
        }
    }
}
