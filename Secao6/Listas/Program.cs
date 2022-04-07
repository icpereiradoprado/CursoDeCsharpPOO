using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Double> numeros = new List<Double> { 45.00,12.45,47.65,10.10};

            foreach(double num in numeros)
            {
                Console.WriteLine(num);
            }

            
        }
    }
}