using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "111";
            musteri1.Adi = "Ayşegül";
            musteri1.Soyadi = "Demirhan";
            musteri1.TcNo = "1234124124";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "222";
            musteri2.SirketAdi = "Ramazan Demirhan";
            musteri2.VergiNo = "11123141";

            //Gerçek Müşteri - Tüzel Müşteri
            /*SOLID*/

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new GercekMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
