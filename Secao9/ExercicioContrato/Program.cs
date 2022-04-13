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
            string departamentName = Console.ReadLine();
            
            Console.WriteLine("\n--- Enter worker data ---\n");

            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior|MidLevel|Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Departament departatament = new Departament(departamentName);
            Worker worker = new Worker(workerName, workerLevel, baseSalary, departatament);

            Console.Write("How many contracts to this worker? ");
            int quantityContracts = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantityContracts; i++)
            {
                Console.WriteLine("\nEnter #" + (i + 1) + " contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int workHours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date,valuePerHour,workHours);
                worker.addContract(contract);
            }

            Console.Write("\n\nEnter month ad year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month):F2}");
            

        }
    }
}