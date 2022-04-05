// See https://aka.ms/new-console-template for more information
using System;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Digite o nome do produto: ");
            produto.setNome(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: ");
            produto.setPreco(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a quantidade em estoque do produto: ");
            produto.setQunatidade(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados do Produto: {produto}");

            Console.WriteLine("\nDigite o número de produtos a ser adicionado ao estoque: ");
            produto.adicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados Atualizados: {produto}");

            Console.WriteLine("\nDigite o número de produtos a ser removido do estoque: ");
            produto.removerProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados Atualizados: {produto}");


        }
    }
}
