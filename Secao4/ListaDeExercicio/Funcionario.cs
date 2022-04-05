using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicio
{
    class Funcionario
    {
        //atributos
        private string Nome;
        private double SalarioBruto;
        private double Imposto;

        //gets e sets 

        //get e set Nome
        public string getNome()
        {
            return this.Nome;
        }

        public void setNome(string _nome)
        {
            this.Nome = _nome;
        }

        //get e set Salario Bruto
        public double getSalarioBruto()
        {
            return this.SalarioBruto;
        }

        public void setSalarioBruto(double _salarioBruto)
        {
            this.SalarioBruto = _salarioBruto;
        }

        //get e set Imposto

        public double getImposto()
        {
            return this.Imposto;
        }

        public void setImposto(double _imposto)
        {
            this.Imposto = _imposto;
        }

        //demais metodos
        public double SalarioLiquido()
        {
            double salarioLiquido = this.SalarioBruto - this.Imposto;
            return Math.Round(salarioLiquido, 2);
        }
        public void AumentarSalario(double _porcentagem)
        {
            this.SalarioBruto = this.SalarioBruto * (_porcentagem / 100 + 1);
        }

        public override string ToString()
        {
            return $"Funcionário: {this.Nome}, R$ {SalarioLiquido():F2}";
        }
    }
}
