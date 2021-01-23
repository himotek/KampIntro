using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager

    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi + " - Kalan Stok Adedi: " + urun.StokAdedi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
