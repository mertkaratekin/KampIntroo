using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise
{
    internal class DatabaseLoggerManager : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı. ");
        }
    }
}
