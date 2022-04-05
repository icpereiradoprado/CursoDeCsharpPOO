using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicio
{
    class Aluno
    {
        //Atributos
        private string Nome;
        private double Nota1;
        private double Nota2;
        private double Nota3;

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

        //get e set Nota1

        public double getNota1()
        {
            return this.Nota1;
        }

        public void setNota1(double _nota1)
        {
            this.Nota1 = _nota1;
        }

        //get e set Nota2

        public double getNota2()
        {
            return this.Nota2;
        }

        public void setNota2(double _nota2)
        {
            this.Nota2 = _nota2;
        }

        //get e set Nota3

        public double getNota3()
        {
            return this.Nota3;
        }

        public void setNota3(double _nota3)
        {
            this.Nota3 = _nota3;
        }

        //demais métodos

        public double NotaFinal()
        {
            return this.Nota1 + this.Nota2 + this.Nota3;
        }

        public string AlunoAprovado()
        {
            string aprovacao = "";
            if(NotaFinal() >= 60.00)
            {
                aprovacao = "Aluno Aprovado";
            }
            else
            {
                double notaFaltante = 60.00 - NotaFinal(); ;
                aprovacao = $"Aluno Reprovado\nFaltaram {notaFaltante:F2} pontos para o aluno atingir a média";
            }

            return aprovacao;
        }


    }
}
