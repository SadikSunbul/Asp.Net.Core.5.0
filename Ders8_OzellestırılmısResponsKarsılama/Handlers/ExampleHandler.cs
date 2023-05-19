using Microsoft.AspNetCore.Http;

namespace Ders8_OzellestırılmısResponsKarsılama.Hendlers
{
    public class ExampleHandler
    {
        public RequestDelegate Handler()
        {
            return async c =>
            {
                //https://localhost:5000/example-roote endpoıntıne gelen herhangı bır ıstek controller dan ziyade drekt olarak buradakı fonksıyondan tarafından karsılanacaktır 
                await c.Response.WriteAsync("Hello word");
            };
        }
    }
}
