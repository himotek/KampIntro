using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            // do not repeat yourself
            // kategoriEtiketi = değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double notOrtalamasi = 4.14;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi butonu");

            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(notOrtalamasi);




        }
    }
}
