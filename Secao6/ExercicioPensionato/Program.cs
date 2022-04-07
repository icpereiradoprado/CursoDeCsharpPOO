using System;

/*A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.*/


namespace ExercicioPensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            int quartoDesejado;
            Console.Write("Quantidade de alunos que irão alugar os quartos: ");
            int quantidadeEstudante = int.Parse(Console.ReadLine());

            Estudante[] estudantes = new Estudante[10];

            for (int i = 0; i < quantidadeEstudante; i++)
            {
                Console.WriteLine("Aluguel #"+(i+1)+":");
                Console.Write("Nome: ");
                string nomeEstudante = Console.ReadLine();
                Console.Write("E-mail: ");
                string emailEstudante = Console.ReadLine();
                while (true)
                {
                    Console.Write("Quarto: ");
                    quartoDesejado = int.Parse(Console.ReadLine());
                    
                    if (estudantes[quartoDesejado-1] == null)
                    {
                        estudantes[quartoDesejado-1] = new Estudante(nomeEstudante, emailEstudante);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Quarto Ocupado!! Por favor escolha outro. ");
                    }
                }
                
            }

            Console.WriteLine($"Quartos Ocupados:");
            int contador = 0;
            foreach(var x in estudantes)
            {
                contador++;
                if (x != null)
                {
                    Console.WriteLine($"{contador}:{x}");
                }
            }

        }
    }
}