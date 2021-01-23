using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ramazan";
            int yas = 29;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ramazan Demirhan";
            kurs1.IzlenmeOrani = 71;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Ramazan Demirhan";
            kurs2.IzlenmeOrani = 41;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Ayşegül Demirhan";
            kurs3.IzlenmeOrani = 99;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Ayşegül Demirhan";
            kurs4.IzlenmeOrani = 69;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen+" "+kurs1.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen + " " + kurs.IzlenmeOrani);

            }
        }
    }
}

class Kurs
{
    public string KursAdi { get; set; }

    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}

