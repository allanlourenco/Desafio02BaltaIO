using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO.Classificacoes
{
    public class Sobrepeso : Classificacao
    {
        public override string Descricao
        {
            get { return "Sobrepeso"; }
        }

        public override string Risco
        {
            get { return "Aumentado"; }
        }

        public override bool ChecarIMC(double imc) => imc >= 25.00 && imc <= 29.99;
    }
}
