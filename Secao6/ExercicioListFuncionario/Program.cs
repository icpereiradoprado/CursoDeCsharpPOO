using System;
using System.Collections.Concurrent;

/*
Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
 */
namespace ExercicioListFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            Console.Write("Digite a quantidade de funcionarios para o cadastro: ");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidadeFuncionarios; i++)
            {
                Console.WriteLine("\nFuncionário #"+(i+1)+":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                funcionario.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nEntre com o ID do funcionário que receerá o aumento salarial: ");
            int procuraId = int.Parse(Console.ReadLine());

            Funcionario verificaID = funcionario.Find(x => x.Id == procuraId);

            if (verificaID != null)
            {
                Console.Write("Entre com a porcentagem para o aumento salárial: ");
                double porcentagemAumento = double.Parse(Console.ReadLine());
                verificaID.Aumento(porcentagemAumento);
            }
            else
            {
                Console.WriteLine("\nEsse ID não existe!");
            }

            Console.WriteLine("\nLista de funcionários atualizados");
            foreach(var x in funcionario)
            {
                Console.WriteLine(x);
            }
        }
    }
}