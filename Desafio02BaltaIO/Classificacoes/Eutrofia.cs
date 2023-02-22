using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO.Classificacoes
{
    public class Eutrofia : Classificacao
    {
        public override string Descricao
        {
            get { return "Eutrofia"; }
        }

        public override string Risco
        {
            get { return "Sem Risco"; }
        }

        public override bool ChecarIMC(double imc) => imc >= 18.50 && imc <= 24.99;
    }
}
