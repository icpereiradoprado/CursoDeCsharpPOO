using System;
using System.Globalization;

namespace ExercicioMembroEstatico
{
    class Program
    {
        /*static double Pi = 3.14; //Variável estática para a primeira solução */

        //TERCEIRA SOLUÇÃO
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Cisrcunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        //SEGUNDA SOLUÇÃO
        /*static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);

            Console.WriteLine("Cisrcunferência: "+circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: "+calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }*/


        //PRIMEIRA SOLUÇÃO
        /*static void Main(string[] args)
        {

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Cisrcunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }*/
    }
}