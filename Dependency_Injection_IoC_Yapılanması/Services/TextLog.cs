using System;
using System.Threading.Channels;
using Dependency_Injection_IoC_Yapılanması.Controllers.Services.Interface;

namespace Dependency_Injection_IoC_Yapılanması.Controllers.Services
{
    public class TextLog : ILog
    {
        
        public void Log()
        {
          
            Console.WriteLine("Text dosyasına loglama gerceklestırıldi ..."+a);
        }
    }
}
