using Desafio02BaltaIO.Classificacoes;
using System;

namespace Desafio02BaltaIO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*************DESAFIO 02 - BALTA.IO**************");
                Console.WriteLine("");
                Console.WriteLine("Informe sua altura: ");
                float.TryParse(Console.ReadLine(), out float altura);
                Console.WriteLine("Informe seu peso: ");
                float.TryParse(Console.ReadLine(), out float peso);

                ValidarCampos(altura, peso);

                var imc = new Calculadora().CalcularIMC(altura, peso);
                var classificacao = new ListaClassificacoes().BuscarClassificaoPorIMC(imc);

                Console.WriteLine($"Seu IMC é {imc}");
                Console.WriteLine(classificacao.Descricao);
                Console.WriteLine($"Risco: {classificacao.Risco}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ValidarCampos(float altura, float peso)
        {
            if (altura <= 0 || peso <= 0)
                throw new Exception("Insira valores válidos...");
        }
    }
}
