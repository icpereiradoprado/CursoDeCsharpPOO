using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program 
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Entre com o número da conta: ");
                string numeroConta = Console.ReadLine();

                Console.Write("Entre com o titutlar da conta: "); 
                string nomeTitular = Console.ReadLine();

                Console.Write("Haverá depósito inicial? [s/n]: ");
                char resposta = char.Parse(Console.ReadLine());
            
                if (char.ToUpper(resposta)== 'S')
                {
                    Console.Write("Entre com o valor de depósito inicial: ");
                    double valorInicialDeposito = double.Parse(Console.ReadLine());

                    ContaBancaria conta1 = new ContaBancaria(numeroConta, nomeTitular, valorInicialDeposito);
                    Console.WriteLine("\n"+conta1);

                    Console.Write("Entre com o valor do depósito: ");
                    conta1.Deposito(double.Parse(Console.ReadLine()));
                    Console.WriteLine("\nDados da conta atualizados: ");
                    Console.WriteLine(conta1);


                    Console.Write("Entre com o valor para saque: ");
                    conta1.Saque(double.Parse(Console.ReadLine()));
                    Console.WriteLine("\nDados da conta atualizados: ");
                    Console.WriteLine(conta1);

                    break;

                }
                else if (char.ToUpper(resposta) == 'N')
                {
                    ContaBancaria conta1 = new ContaBancaria(numeroConta, nomeTitular);
                    Console.WriteLine("\n"+conta1);

                    Console.Write("Entre com o valor do depósito: ");
                    conta1.Deposito(double.Parse(Console.ReadLine()));
                    Console.WriteLine("\nDados da conta atualizados: ");
                    Console.WriteLine(conta1);

                    Console.Write("Entre com o valor para saque: ");
                    conta1.Saque(double.Parse(Console.ReadLine()));
                    Console.WriteLine("\nDados da conta atualizados: ");
                    Console.WriteLine(conta1);
                    break;

                }
                else
                {
                    Console.WriteLine("Você digitou uma resposta inválida!");
                }
            }
            
        }
    }

}