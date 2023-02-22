using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO.Classificacoes
{
    public class MagrezaGrauI : Classificacao
    {
        public override string Descricao
        {
            get { return "Magreza Grau I"; }
        }

        public override string Risco
        {
            get { return "Sem Risco"; }
        }

        public override bool ChecarIMC(double imc) => imc >= 17.00 && imc <= 18.49;
    }
}
