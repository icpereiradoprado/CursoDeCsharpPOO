using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Pessoa
    {
        private string _nome;
        private string _cpf;

        //Construtores
        public Pessoa(string nome, string cpf)
        {
            this._nome = nome;
            this._cpf = cpf;
        }
        
        //Properties

        public string Nome
        {
            get { return this._nome; }
            set 
            { 
                if(value != null && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }

        public string Cpf
        {
            get { return this._cpf; }
            set 
            { 
                if (value != null && value.Length == 11)
                {
                    this._cpf = value;
                } 
            }

        }

        //demais métodos

        public override string ToString()
        {
            return $"Nome: {this._nome} | CPF: {this._cpf}";
        }
    }
}
