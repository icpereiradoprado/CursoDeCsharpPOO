using System;
using System.Globalization;

namespace ExercicioEstaticoCotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantideCompraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais => R$ {ConversorDeMoeda.ConverteDolarReais(cotacao, quantideCompraDolar):F2}");
        }
    }
}
