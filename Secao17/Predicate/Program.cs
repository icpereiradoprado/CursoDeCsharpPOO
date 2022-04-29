using System;
using System.Collections.Concurrent;
using Predicate.Entities;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV",900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price <= 100.00);
            //list.RemoveAll(ProductTest);
            //Action<Product> act = act = p => { p.Price += p.Price * 0.1; }; // No caso de uma ação eu devo abrir e fechar as chaves para indicar que ela tem um corpo e não irá retornar algo, já que ela é uma função void.
            list.ForEach(p => p.Price += p.Price * 0.1);
            //list.ForEach(UpdatePrice);
            foreach(Product products in list)
            {
                Console.WriteLine(products);
            }
        }

        /*
        //Método para retornar um booleano para o exemplo de Predicate - RemoveAll
        public static bool ProductTest(Product p)
        {
            return p.Price <= 100.00;
        }*/

        //Method to return increase of 10% in prices of products
        /*public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }*/


    }
}