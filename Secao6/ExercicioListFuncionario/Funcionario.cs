using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListFuncionario
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        //constrututores

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public double Aumento(double porcentagemAumento)
        {
            return Salario*= (porcentagemAumento/100) + 1;
        }

        public override string ToString()
        {
            return $"{Id} | {Nome} | R$ {Salario:F2}";
        }
    }
}
