using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO
{
    public class Calculadora
    {
        private const int POTENCIAELEVADA = 2;
        public double CalcularIMC(float altura, float peso) => ArredondarValorParaDoisDigitos(peso / Math.Pow(altura, POTENCIAELEVADA));
        private double ArredondarValorParaDoisDigitos(double resultado) => Math.Round(resultado, 2);
    }
}
