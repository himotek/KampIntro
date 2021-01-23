﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // OOP = Object oriented programming - nesne yönelimli programlama
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase //CamelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            ProductManager productManager1 = new ProductManager();
            productManager1.Update(product2);
            Console.WriteLine(product2.ProductName);



            // int,double,bool ... değer tip
            // diziler,class,abstract class,interface ... referans tip
        }
    }
}
