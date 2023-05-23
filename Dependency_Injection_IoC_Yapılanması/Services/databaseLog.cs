using System;
using Dependency_Injection_IoC_Yapılanması.Controllers.Services.Interface;

namespace Dependency_Injection_IoC_Yapılanması.Controllers.Services
{
    public class databaseLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Database Log yapıldı");
        }
    }
}
