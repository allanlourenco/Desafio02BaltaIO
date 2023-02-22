using System;
using Xunit;

namespace Desafio02BaltaIO.Teste1
{
    public class CalculadoraTeste
    {
        [Theory]
        [InlineData(90.2, 1.75, 29.45)]
        [InlineData(75, 1.95, 19.72)]
        public void TestCalculateSuccess(float peso, float altura, float resultadoEsperado)
        {
            var resultado = new Calculadora().CalcularIMC(altura, peso);
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
