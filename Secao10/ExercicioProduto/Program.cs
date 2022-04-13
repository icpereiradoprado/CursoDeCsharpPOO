using System;
using ExercicioProduto.Entities;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of product: ");
            int numberProduct = int.Parse(Console.ReadLine());

            List<Product> product = new List<Product>();

            for (int i = 1; i <= numberProduct; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported [c/u/i]? ");
                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                char option = char.Parse(Console.ReadLine());
                if(option == 'c')
                { 
                    product.Add(new Product(nameProduct, priceProduct));
                }
                else if(option == 'u')
                {
                    Console.Write("Manufacutere date (DD/MM/YYYY): ");
                    DateTime manufacutereDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(nameProduct, priceProduct, manufacutereDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee= double.Parse(Console.ReadLine());
                    product.Add(new ImportedProduct(nameProduct, priceProduct, customsFee));
                }

            }
            Console.WriteLine("\n\nPRICE TAG:");
            foreach(Product p in product)
            {
                Console.WriteLine($"{p}");
            }
            
        }
    }
}