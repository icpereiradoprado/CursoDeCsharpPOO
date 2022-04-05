using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTriangulo
{
    class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        //Construtor

        public Triangulo(double _ladoA, double _ladoB, double _ladoC)
        {
            this.ladoA = _ladoA;
            this.ladoB = _ladoB;
            this.ladoC = _ladoC;
        }
        //gets e sets

        //Gets e Sets LadoA
        public double getLadoA()
        {
            return this.ladoA;
        }

        public void setLadoA(double _ladoA)
        {
            this.ladoA = _ladoA;
        }

        //Gets e Sets LadoB
        public double getLadoB()
        {
            return this.ladoB;
        }

        public void setLadoB(double _ladoB)
        {
            this.ladoB = _ladoB;
        }

        //Gets e Sets LadoC
        public double getLadoC()
        {
            return this.ladoC;
        }

        public void setLadoC(double _ladoC)
        {
            this.ladoC = _ladoC;
        }

        //demais métodos

        public double AreaTriangulo()
        {
            double p = (this.ladoA + this.ladoB + this.ladoC) / 2.0;
            return Math.Sqrt(p * (p - this.ladoA) * (p - this.ladoB) * (p - this.ladoC));
        }
        public string retornaString()
        {
            return $"\tLadoA = {this.ladoA}\n\tLadoB = {this.ladoB}\n\tLadoC = {this.ladoC}";
        }

        public string Maior(double _areaTriangulo1, double _areaTriangulo2)
        {
            string maior = "";
            if (_areaTriangulo1 > _areaTriangulo2)
            {
                maior = "O 1° triângulo tem área maior";
            }
            else if (_areaTriangulo1 < _areaTriangulo2)
            {
                maior = "O 2º triângulo tem área maior";
            }
            else
            {
                maior = "Ambos triângulos possuem áreas iguais";
            }

            return maior;
        }


    }


}
