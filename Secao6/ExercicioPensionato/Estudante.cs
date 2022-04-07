using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPensionato
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        //construtor

        public Estudante(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} | Email: {Email}";
        }
    }
}
