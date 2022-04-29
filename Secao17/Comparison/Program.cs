﻿using System;
using Comparison.Entities;

namespace Comparison
{
    class Project
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Comparison<Product> comp = CompareProducts;
            //Comparison<Product> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //list.Sort(comp);

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }

            /*static int CompareProducts(Product p1, Product p2)
            {
                return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            }*/
        }
    }
}
