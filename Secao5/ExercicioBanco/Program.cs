using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program 
    {
        static void Main(string[] args)
        {
            char[] resposta = new char[1];

            while (true)
            {
                Console.Write("Entre com o número da conta: ");
                string numeroConta = Console.ReadLine();

                Console.Write("Entre com o titutlar da conta: "); 
                string nomeTitular = Console.ReadLine();

                Console.Write("Haverá depósito inicial? [s/n]: ");
                resposta[0] = char.Parse(Console.ReadLine());

            
                if (resposta[0] == 'S' || resposta[0] == 's')
                {
                    Console.Write("Entre com o valor de depósito inicial: ");
                    double valorInicialDeposito = double.Parse(Console.ReadLine());

                    ContaBancaria conta1 = new ContaBancaria(numeroConta, nomeTitular, valorInicialDeposito);
                    Console.WriteLine(conta1);

                    Console.Write("Entre com o valor do depósito: ");
                    conta1.Deposito(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine(conta1);


                    Console.Write("Entre com o valor para saque: ");
                    conta1.Saque(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine(conta1);

                    break;

                }
                else if (resposta[0] == 'N' || resposta[0] == 'n')
                {
                    ContaBancaria conta1 = new ContaBancaria(numeroConta, nomeTitular);
                    Console.WriteLine(conta1);

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