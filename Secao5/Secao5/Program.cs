using System;

namespace Secao5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            
            Produto produto = new Produto(nome,preco,quantidade);
            Console.WriteLine($"{produto}");
            produto.SetQuantidade(10);
            Console.WriteLine($"{produto}");

            Console.WriteLine("\nDigite a quantidade de produtos que será adicionado: ");
            produto.AdicionarProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados...\n{produto}");

            Console.WriteLine("\nDigite a quantidade de produtos que será removido: ");
            produto.RemoverProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados...\n{produto}");

            Produto produto2 = new Produto();
            
        }
    }
}