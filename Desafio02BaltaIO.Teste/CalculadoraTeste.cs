using NUnit.Framework;
using Xunit;

namespace Desafio02BaltaIO.Teste
{
    public class CalculadoraTeste
    {
        [Xunit.Theory]
        [InlineData(90.2, 1.75, 29.45)]
        [InlineData(75, 1.95, 19.72)]
        public void TestCalculateSuccess(float weight, float height, float resultExpected)
        {
            var result = new Calculadora().CalcularIMC(weight, height);
            Assert.Equals(resultExpected, result);
        }
    }
}