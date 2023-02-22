using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO.Classificacoes
{
    public class ObesidadeGrauI: Classificacao
    {
        public override string Descricao
        {
            get { return "Obesidade Grau I"; }
        }

        public override string Risco
        {
            get { return "Moderado"; }
        }

        public override bool ChecarIMC(double imc) => imc >= 30.00 && imc <= 34.99;
    }
}
