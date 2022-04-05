using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosExercicios
{
    class Pessoa
    {
        private string Nome;
        private int Idade;

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

        //get e set idade
        public int getIdade()
        {
            return this.Idade;
        }

        public void setIdade(int _idade)
        {
            this.Idade = _idade;
        }

    }
}
