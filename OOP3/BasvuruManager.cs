using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) 
        {
            /*Başvuran bilgilerini değerlendirme*/
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap( List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
        public void LogBilgi(List<ILoggerService> loggers)
        {
            foreach (var logger in loggers)
            {
                logger.Log();

            }
        }
    }
}
