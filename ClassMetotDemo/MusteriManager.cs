using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddCustomer (Musteri musteri )
        {
            Console.WriteLine("Customer Added : " + musteri.Id +"Welcome : " + musteri.Name + musteri.Surname );
            Console.WriteLine("Personal Information : " + "Age : " + musteri.Age + "Your Balance : " + musteri.Balance );
        }

        public void DeleteCustomer (Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" "+ musteri.Name+" "+musteri.Surname+"  Deleted !!"  );
        }
        public void UpdateCustomer (Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+musteri.Name+" "+musteri.Surname+"  Updated..");
        }
        public void ShowCustomer (Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+musteri.Name+" "+musteri.Surname+" ");
        }
    }
}
