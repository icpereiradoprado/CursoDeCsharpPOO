using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosExercicios
{
    class Funcionario
    {
        private string Nome;
        private double Salario;

        //gets e sets

        //get e set nome
        public string getNome()
        {
            return this.Nome;
        }

        public void setNome(string _nome)
        {
            this.Nome = _nome;
        }

        //get e set salario
        public double getSalario()
        {
            return this.Salario;
        }

        public void setSalario(double _salario)
        {
            this.Salario = _salario;
        }
    }
}
