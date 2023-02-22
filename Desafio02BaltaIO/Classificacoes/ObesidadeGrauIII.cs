using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO.Classificacoes
{
    public class ObesidadeGrauIII : Classificacao
    {
        public override string Descricao
        {
            get { return "Obesidade Grau III"; }
        }

        public override string Risco
        {
            get { return "Muito Grave"; }
        }

        public override bool ChecarIMC(double imc) => imc > 40.00;
    }
}
