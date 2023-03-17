using System;
namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtıyacKrediManager = new IhtıyacKrediManager();
            IKrediManager tasitKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService  = new DatabaseLoggerService();    
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService otomasyonLoggerService  = new OtomasyonLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager/*new TasıtKrediManager()*/, databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtıyacKrediManager,tasitKrediManager/*new TasıtKrediManager()*/, esnafKrediManager
            , konutKrediManager};

            List<ILoggerService> loggers = new List<ILoggerService>() {databaseLoggerService,otomasyonLoggerService,fileLoggerService };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            basvuruManager.LogBilgi(loggers);

        }
    }
}