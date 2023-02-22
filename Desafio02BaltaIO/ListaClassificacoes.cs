using Desafio02BaltaIO.Classificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02BaltaIO
{
    public class ListaClassificacoes
    {

        private readonly IList<Classificacao> _classificacoes = new List<Classificacao>()
        {
            new Eutrofia(),
            new MagrezaGrauI(),
            new MagrezaGrauII(),
            new MagrezaGrauIII(),
            new ObesidadeGrauI(),
            new ObesidadeGrauII(),
            new ObesidadeGrauIII(),
            new Sobrepeso()
        };

        public Classificacao BuscarClassificaoPorIMC(double imc) => _classificacoes.FirstOrDefault(x => x.ChecarIMC(imc))!;
    }
}
