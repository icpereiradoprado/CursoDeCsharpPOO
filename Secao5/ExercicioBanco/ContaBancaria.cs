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
        public double Saldo { get; private set; }
        public string NumeroConta { get; private set; }

        //Construtores

        public ContaBancaria(string numeroConta, string nomeTitular)
        {
            this.NumeroConta = numeroConta;
            this._nomeTitular = nomeTitular;
        }

        public ContaBancaria(string numeroConta, string nomeTitular, double valorInicialDeposito) : this(numeroConta, nomeTitular)
        {
            Deposito(valorInicialDeposito);
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
            if (valorDeposito > 0)
            {
                this.Saldo += valorDeposito;
            }
            return Saldo;
        }

        public double Saque(double valorSaque)
        {
            if (valorSaque > 0)
            {
                this.Saldo = (this.Saldo - valorSaque) - 5.00;
            }
            return this.Saldo;
        }

        public override string ToString()
        {
            return $"Conta: {this.NumeroConta} | Titular: {this._nomeTitular} | Saldo R$ {this.Saldo:F2}\n";
        }

    }
}
