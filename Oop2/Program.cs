using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.MusteriNo = "12345";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;    
            musteri2.SirketAdi = "Kodlama.IO";
            musteri2.MusteriNo = "12345";
            musteri2.VergiNo = "123456789";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();/*reference no*/
            /*musteri classı hem gerçek müşterinin hemde tüzel
             müşterinin referansını tutabilir.*/
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);
        }

    }
}