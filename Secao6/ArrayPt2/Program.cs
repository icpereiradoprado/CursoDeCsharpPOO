using System;
using System.Globalization;

namespace ArrayPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanhoVetor = int.Parse(Console.ReadLine());
            double somaPrecoProduto = 0.00;
            Produto[] produto = new Produto[tamanhoVetor];

            for(int i = 0; i < produto.Length; i++)
            {
                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preco: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto[i] = new Produto { Nome = nomeProduto, Preco = precoProduto };
                somaPrecoProduto += produto[i].Preco; // Ou  somaPrecoProduto += nomeProduto;

            }

            Console.WriteLine(somaPrecoProduto.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}