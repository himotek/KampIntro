using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 11;
            musteri1.Name = "Ayşegül";
            musteri1.Surname= "Kaplan";
            musteri1.Age = 26;
            musteri1.Balance= 40000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 22;
            musteri2.Name = "Ramazan";
            musteri2.Surname = "Demirhan";
            musteri2.Age = 29;
            musteri2.Balance = 41000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id : " + musteri.Id);
                Console.WriteLine("Müşteri Ad : " + musteri.Name);
                Console.WriteLine("Müşteri Soyad : " + musteri.Surname);
                Console.WriteLine("Müşteri Yaşı : " + musteri.Age);
                Console.WriteLine("Müşteri Gelir : " + musteri.Balance);
                Console.WriteLine("----------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.AddCustomer(musteri1);
            musteriManager.AddCustomer(musteri2);
            musteriManager.ShowCustomer(musteri1);
            musteriManager.ShowCustomer(musteri2);
            musteriManager.UpdateCustomer(musteri1);
            musteriManager.UpdateCustomer(musteri2);
            musteriManager.DeleteCustomer(musteri1);
            musteriManager.DeleteCustomer(musteri2);

        }
    }
}
