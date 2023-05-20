using System;
using Dependency_Injection_IoC_Yapılanması.Controllers.Services.Interface;

namespace Dependency_Injection_IoC_Yapılanması.Controllers.Services
{
    public class ConsoleLog:ILog
    {
        public ConsoleLog(int a)
        {
            
        }

        public void Log()
        {
            Console.WriteLine("Konsola loglama ıslemeı gerceklestırırldi ....");
        }
    }
}
