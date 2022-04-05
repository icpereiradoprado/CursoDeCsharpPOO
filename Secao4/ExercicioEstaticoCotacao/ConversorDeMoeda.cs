using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstaticoCotacao
{
    class ConversorDeMoeda
    {
        private static double IoF = 6.0;



        //demais métodos

        //metodo que converte dólar em reais

        public static double ConverteDolarReais(double _quantidade, double _cotacao)
        {
            return _cotacao * (IoF/100 + 1) * _quantidade;
        }
    }
}
