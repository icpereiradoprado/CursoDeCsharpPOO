using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioBanco
{
    internal class ContaBancaria
    {
        //atributos
        private string _nomeTitular;
        public double ValorInicialDeposito { get; private set; }
        public string NumeroConta { get; private set; }

        //Construtores

        public ContaBancaria(string numeroConta, string nomeTitular)
        {
            this.NumeroConta = numeroConta;
            this._nomeTitular = nomeTitular;
        }

        public ContaBancaria(string numeroConta, string nomeTitular, double valorInicialDeposito) : this(numeroConta, nomeTitular)
        {
            this.ValorInicialDeposito = valorInicialDeposito;
        }

        //Custom Properties

        public string NomeTitular
        {
            get { return _nomeTitular; }
            set 
            {
                if(value != null && value.Length > 1)
                {
                    this._nomeTitular = value;
                }
            }
        }

        //demais métodos
        public double Deposito(double valorDeposito)
        {
            return this.ValorInicialDeposito += valorDeposito;
        }

        public double Saque(double valorSaque)
        {
            this.ValorInicialDeposito = (this.ValorInicialDeposito - valorSaque) - 5.00;
            return this.ValorInicialDeposito;
        }

        public override string ToString()
        {
            return $"\nConta: {this.NumeroConta} | Titular: {this._nomeTitular} | Saldo R$ {this.ValorInicialDeposito:F2}";
        }

    }
}
