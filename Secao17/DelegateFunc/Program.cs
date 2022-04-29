using System.Globalization;
using DelegateFunc.Entities;
using System.Linq;

namespace DelegateFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Delegate Func represent a method that recive zero or more arguments, and return a value.

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //List<string> result = list.Select(NewListToUpper).ToList();
            /*Func<Product, string> func = NewListToUpper;
            List<string> result = list.Select(func).ToList();*/

            /*Func<Product, string> func = p => p.Name.ToUpper();
            List<string> result = list.Select(func).ToList();*/

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach(string upperProduct in result)
            {
                Console.WriteLine(upperProduct);
            }
        }

        /*public static string NewListToUpper(Product p)
        {
            return p.Name.ToUpper();
        }*/

        
    }
}
