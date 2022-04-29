using System.Globalization;
using FixationExercise.Entities;
//C:\Temp\employee.txt
namespace FixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string file = Console.ReadLine();

            List<Employee> listEmployes = new List<Employee>();

            using (StreamReader sr = File.OpenText(file))
            {
                while (!sr.EndOfStream)
                {
                    string[] contents = sr.ReadLine().Split(',');
                    string name = contents[0];
                    string email = contents[1];
                    double salary = double.Parse(contents[2], CultureInfo.InvariantCulture);
                    listEmployes.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double typedSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var nameEmployee = listEmployes.Where(e => e.Salary > typedSalary).OrderBy(e => e.Email).Select(e => $"{e.Name}, {e.Email}");

            var sumSalary = listEmployes.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

            Console.WriteLine("Email of people whose salary is more than "+typedSalary+": ");
            foreach (var employee in nameEmployee)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("Sum of salary of people whose name starts with 'M': "+ sumSalary);

        }

    }
}