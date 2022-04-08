using System;
using Enumeracao.Entites;
using Enumeracao.Entites.Enums;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(1080,DateTime.Now, OrderStatus.PendingPay);
            Console.WriteLine(order);

            string statusInString = order.Status.ToString();
            Console.WriteLine("\n"+statusInString);

            Console.Write("\nEnter order status...\n\t- PendingPay\n\t- Processing\n\t- Shiped\n\t- Delivered\n=> ");
            string teste = Console.ReadLine();

            Enum stringToEnum = Enum.Parse<OrderStatus>(teste);
            Console.WriteLine($"\nUpdate Status: {stringToEnum}");
        }
    }
}