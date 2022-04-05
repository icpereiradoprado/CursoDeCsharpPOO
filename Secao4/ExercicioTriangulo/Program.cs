using System;
using System.Globalization;


namespace ExercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados para o primeiro triângulo
            Console.WriteLine("Digite o tamanho do lado A do triângulo: ");
            double ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do lado B do triângulo: ");
            double ladoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do lado C do triângulo: ");
            double ladoC = double.Parse(Console.ReadLine());
            //ladoA = 3; ladoB = 4; ladoC = 5;

            ////entrada de dados para o segundo triângulo
            Console.WriteLine("Digite o tamanho do lado A do triângulo: ");
            double ladoA2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do lado B do triângulo: ");
            double ladoB2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do lado C do triângulo: ");
            double ladoC2 = double.Parse(Console.ReadLine());
            //ladoA = 7.50; ladoB = 4.50; ladoC = 4.02;
            Triangulo triangulo1 = new Triangulo(ladoA, ladoB, ladoC);
            Triangulo triangulo2 = new Triangulo(ladoA2, ladoB2, ladoC2);

            double area1 = triangulo1.AreaTriangulo();
            double area2 = triangulo2.AreaTriangulo();

            Console.WriteLine($"Lados do 1º Triângulo:\n{triangulo1.retornaString()}");
            Console.WriteLine($"\nA área do 1º Triângulo é: {area1:F4}");
            Console.WriteLine($"\nA área do 1º Triângulo é: {area2:F4}");
            Console.WriteLine($"\nMaior área:\n\t{triangulo1.Maior(area1, area2)}");
        }

    }

}