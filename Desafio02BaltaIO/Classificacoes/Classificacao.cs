using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO.Classificacoes
{
    public abstract class Classificacao
    {
        public abstract string Descricao { get; }
        public abstract string Risco { get; }
        public abstract bool ChecarIMC(double imc);
    }
}
