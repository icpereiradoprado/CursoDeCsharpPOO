using System;
using ExercicioContrato.Entities;
using ExercicioContrato.Entities.Enums;

namespace ExercicioContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string nameDepartament = Console.ReadLine();
            
            Console.WriteLine("\n--- Enter worker data ---\n");

            Console.Write("Name: ");
            string nameWoroker = Console.ReadLine();
            Console.Write("Level (Junior|MidLevel|Senior: )");
            WorkerLevel workLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int quantityContracts = int.Parse(Console.ReadLine());
        }
    }
}