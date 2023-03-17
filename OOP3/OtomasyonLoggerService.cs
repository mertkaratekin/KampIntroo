using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class OtomasyonLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Otomasyona loglandı. ");
        }
    }
}
