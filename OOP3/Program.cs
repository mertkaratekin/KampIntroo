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

            ILoggerService databaseLoggerService  = new DatabaseLoggerService();    
            ILoggerService fileLoggerService = new FileLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtıyacKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtıyacKrediManager
            , konutKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}