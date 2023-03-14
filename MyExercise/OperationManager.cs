using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise
{
    internal class OperationManager
    {
        public void YakitAl(IAkaryakitManager akaryakitManager, ILoggerManager loggerManager) 
        {
            akaryakitManager.Hesapla();
            loggerManager.Log();
        }
        public void BilgiAl(List<IAkaryakitManager> akaryakits) 
        {
            foreach (var akaryakit in akaryakits)
            {
                akaryakit.Hesapla();
                
            }
        }
        public void LogBilgiAl(List<ILoggerManager> loggers) 
        {
            foreach (var logger in loggers)
            {
                logger.Log();
            }
        }
    }
}
