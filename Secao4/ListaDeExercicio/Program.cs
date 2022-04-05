// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace ListaDeExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1
            /*Retangulo retangulo = new Retangulo();
            
            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            retangulo.setLargura(double.Parse(Console.ReadLine()));
            retangulo.setAltura(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Área = {retangulo.AreaRetangulo():F2}\nPerímetro = {retangulo.PerimetroRetangulo():F2}\nDiagonal = {retangulo.DiagonalRetangulo():F2}");*/

            //EXERCÍCIO 2
           /* Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.setNome(Console.ReadLine());
            Console.Write("Salário Bruto: ");
            funcionario.setSalarioBruto(double.Parse(Console.ReadLine()));
            Console.Write("Imposto: ");
            funcionario.setImposto(double.Parse(Console.ReadLine()));

            Console.WriteLine(funcionario);

            Console.Write("Digte a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine($"\nDados Atualizados...\n\t{funcionario}");*/

            //Exercicio 3
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.setNome(Console.ReadLine());
            Console.WriteLine("Digite as três notas do aluno");
            aluno.setNota1(double.Parse(Console.ReadLine()));
            aluno.setNota2(double.Parse(Console.ReadLine()));
            aluno.setNota3(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Nota Final = {aluno.NotaFinal():F2}");
            Console.WriteLine(aluno.AlunoAprovado());


        }
    }
}
