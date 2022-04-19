using System;
using System.Collections.Generic;
using TratamentoDeExecoes.Entities.Exceptions;
using TratamentoDeExecoes.Entities;

namespace TratamentoDeExecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine());


                Account account = new Account(accountNumber, holder, withDrawLimit);
                account.Deposit(balance);

                Console.Write("\n\nEnter amount for withdraw: ");
                double ammount = double.Parse(Console.ReadLine());
                account.WithDraw(ammount);

                Console.WriteLine($"New Balance: {account.Balance:F2}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }


        }
    }
}
