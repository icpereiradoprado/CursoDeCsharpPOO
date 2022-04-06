using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de alturas que serão inseridas: ");
            int quantidadeAlturas = int.Parse(Console.ReadLine());
            double somaAlturas = 0.00;
            double[] alturas = new double[quantidadeAlturas];

            for(int i = 0; i < alturas.Length; i++)
            {
                Console.Write("Digite um número para a " + (i + 1)+"º posição do vetor: ");
                alturas[i] = double.Parse(Console.ReadLine());
                somaAlturas+=alturas[i];
            }

            double mediaAlturas = somaAlturas / quantidadeAlturas;
            Console.WriteLine($"A média das alturas é {mediaAlturas:F2}"); 
           
        }
    }
}