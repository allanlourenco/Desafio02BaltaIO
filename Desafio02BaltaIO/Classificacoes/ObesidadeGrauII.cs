using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO.Classificacoes
{
    public class ObesidadeGrauII : Classificacao
    {
        public override string Descricao
        {
            get { return "Obesidade Grau II"; }
        }

        public override string Risco
        {
            get { return "Grave"; }
        }

        public override bool ChecarIMC(double imc) => imc >= 35.00 && imc <= 40.00;
    }
}
