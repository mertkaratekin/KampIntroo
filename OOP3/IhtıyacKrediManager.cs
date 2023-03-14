using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class IhtıyacKrediManager : IKrediManager

    {
        public void Hesapla()
        {
            Console.WriteLine("Ihtıyaç kredisi ödeme planı" +" "+
               "hesaplandı.");
        }
    }
}
