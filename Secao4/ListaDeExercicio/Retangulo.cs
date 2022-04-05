using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicio
{
    class Retangulo
    {
        //atributos
        private double Largura;
        private double Altura;

        //gets e sets

        //get e set Largura
        public double getLargura()
        {
            return this.Largura;
        }

        public void setLargura(double _largura)
        {
            this.Largura = _largura;
        }

        //get e set Altura
        public double getAltura()
        {
            return this.Altura;
        }

        public void setAltura(double _altura)
        {
            this.Altura = _altura;
        }

        //demais metodos

        //metodo que retornará a área do retângulo

        public double AreaRetangulo()
        {
            return this.Largura * this.Altura;
        }

        public double PerimetroRetangulo()
        {
            return 2 * (this.Largura + this.Altura);
        }

        public double DiagonalRetangulo()
        {
            return Math.Sqrt(Math.Pow(this.Largura, 2) + Math.Pow(this.Altura, 2));
        }
    }
}
