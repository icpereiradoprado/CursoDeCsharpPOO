using System;

namespace Properties
{
    class Program 
    { 
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Isaac","44455566677");

            Console.WriteLine(pessoa);

            pessoa.Nome = "João";
            pessoa.Cpf = "12345678910";

            Console.WriteLine(pessoa);
        }
    }

}

