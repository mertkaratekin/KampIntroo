using System;

namespace MyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IAkaryakitManager motorinAkaryakitManager = new MotorinAkaryakitManager();
            IAkaryakitManager kursunsuzAkaryakitManager = new KursunsuzAkaryakitManager();
            IAkaryakitManager otogazAkaryakitManager = new OtogazAkarayakitManager();

            ILoggerManager databaseLoggerManager = new DatabaseLoggerManager();
            ILoggerManager fileLoggerManager = new FileLoggerManager();
            ILoggerManager otomasyonLoggerManager = new OtomasyonLoggerManager();

            List<IAkaryakitManager> akaryakits = new List<IAkaryakitManager>() {motorinAkaryakitManager,kursunsuzAkaryakitManager,
                otogazAkaryakitManager };
            List<ILoggerManager> loggers = new List<ILoggerManager>() {databaseLoggerManager,fileLoggerManager,otomasyonLoggerManager };
            OperationManager operationManager = new OperationManager();
            
            operationManager.BilgiAl(akaryakits);
            operationManager.LogBilgiAl(loggers);

            Console.WriteLine("****************************");
            operationManager.YakitAl(kursunsuzAkaryakitManager,databaseLoggerManager);

        }
    }
}