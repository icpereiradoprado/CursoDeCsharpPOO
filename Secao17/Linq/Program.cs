using Linq.Entities;

namespace Linq
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Linq is a set of technologies based on integration of functionalities of query directly Csharp language.
           

            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>()
            {
                new Product(1,"Computer",1100.00,c2),
                new Product(2,"Hammer",90.00,c1),
                new Product(3,"TV",1700.00,c3),
                new Product(4,"Notebook",1300.00,c2),
                new Product(5,"Saw",80.00,c1),
                new Product(6,"Tablet",700.00,c2),
                new Product(7,"Camera",700.00,c3),
                new Product(8,"Printer",350.00,c3),
                new Product(9,"MacBook",1800.00,c2),
                new Product(10,"Sound Bar",700.00,c3),
                new Product(11,"Level",70.00,c1)

            };


            var result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            /*NOTAÇÃO SIMILAR AO SQL*/

            var resultS =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.00
                select p;

            var result2 = products.Where(p => p.Category.Id == 1).Select(x => x.Name);

            //Minha Solução:
            /*var result3 = products.Where(p => p.Name[0] == 'C').Select(x => $"{x.Name}, {x.Price.ToString("F2", CultureInfo.InvariantCulture)}, { x.Category.Name}");*/

            //Soluçao professor:
            var result3 = products.Where(p => p.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name }); // Esta solução possui a implementação de um objeto anônimo.

            var result4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); // Primeiro ordena pelo preço 'OrderBy(p => p.Price)' e depois os que empatarem serão ordenados pelo 'ThenBy(p => p.Name)'.

            var result5 = result4.Skip(2).Take(4); // Pula os dois primeiros 'Skip(2)' e pega 4 elementos 'Take(4)'.

            var result6 = products.FirstOrDefault();
            var result7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            var result8 = products.Where(p => p.Id == 3).SingleOrDefault();// se eu optar por não usar p 'SingleOrDefault()' o meu objeto 'p' irá retornar um IEnumerable
            var result9 = products.Max(p => p.Price);
            var result10 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            var result11 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            var result12 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((a, b) => a + b);
            var result13 = products.GroupBy(p => p.Category);
            

            Print("TIER 1 AND PRICE LESS THEN $ 900.00: ", result1);

            Print("NAMES OF PRODUCTS FROM TOOLS: ", result2);

            Print("NAMES OF PRODUCTS STARTING WITH THE LETTER C: ", result3);

            Print("CATEGORY TIER 1 ORDER BY PRICE: ", result4);

            Print("CATEGORY TIER 1 ORDER BY PRICE THEN SKIP 2 AND TAKE 4: ", result5);

            Console.WriteLine("First or default, test1: " + result6);

            Console.WriteLine("First or default where price is more than $ 3000.00, test2: " + result7);

            Console.WriteLine("Sigle or default, test1: " + result8);

            Console.WriteLine("Max price: " + result9);

            Console.WriteLine("Sum of Category 1: " + result10);
            
            Console.WriteLine("Average of Category 1: " + result11);

            Console.WriteLine("Aggregate sum Category 1: " + result12);
            
            Console.WriteLine();
            foreach(IGrouping<Category, Product> group in result13)
            {
                Console.WriteLine("Category "+ group.Key.Name + ":");
                foreach(Product product in group)
                {
                    Console.WriteLine(product.Name);
                }
            }

        }
    }
}