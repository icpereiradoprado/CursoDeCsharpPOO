using System;
using System.Globalization;

namespace PrimeirosExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Funcionario primeiroFuncionario = new Funcionario();
            Funcionario segundoFuncionario = new Funcionario();

            //Dados do primeiro funcionario
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            primeiroFuncionario.setNome(Console.ReadLine());
            Console.Write("Salário: ");
            primeiroFuncionario.setSalario(double.Parse(Console.ReadLine()));

            //Dados do segundo funcionario
            Console.WriteLine("\nDados do segundo funcionário: ");
            Console.Write("Nome: ");
            segundoFuncionario.setNome(Console.ReadLine());
            Console.Write("Salário: ");
            segundoFuncionario.setSalario(double.Parse(Console.ReadLine()));

            double mediaSalario = (primeiroFuncionario.getSalario() + segundoFuncionario.getSalario()) / 2.00;

            Console.WriteLine($"\nSalário Médio: {mediaSalario:F2}");

            /*//Dados da primeira pessoa
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            primeiraPessoa.setNome(Console.ReadLine());
            Console.Write("Idade: ");
            primeiraPessoa.setIdade(int.Parse(Console.ReadLine()));

            //dados da segunda pessoa
            Console.WriteLine("\nDados da segunda pessoa: ");
            Console.Write("Nome: ");
            segundaPessoa.setNome(Console.ReadLine());
            Console.Write("Idade: ");
            segundaPessoa.setIdade(int.Parse(Console.ReadLine()));

            //comparando as idades

            if(primeiraPessoa.getIdade() > segundaPessoa.getIdade())
            {
                Console.WriteLine($"\nPessoa mais velha: {primeiraPessoa.getNome()}");
            }
            else
            {
                Console.WriteLine($"\nPessoa mais velha: {segundaPessoa.getNome()}");
            }*/


        }
    }
}
