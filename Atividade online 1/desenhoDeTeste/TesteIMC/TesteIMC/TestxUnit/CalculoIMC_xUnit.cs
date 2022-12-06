using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteIMC;

namespace TestxUnit
{
    public class CalculoIMC_xUnit
    {

/*
        [Fact]

        public void CalcularIMC()
        {
            double peso = 110;
            double altura = 1.79;

            var resultado = Operacoes.CalcularIMC(peso, altura);

            Assert.Equal(34.33, resultado);
        }
*/

        [Theory]

        [InlineData(50, 1.60, 19.53)]
        [InlineData(70, 1.65, 25.71)]
        [InlineData(110, 1.70, 38.06)]
        [InlineData(48, 1.70, 16.61)]
        [InlineData(152, 1.80, 46.91)]
        [InlineData(115, 1.85, 33.60)]
        [InlineData(55, 1.55, 22.89)]

        public void CalculaIMC_Lista(double peso, double altura, double resultado)
        {
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            Assert.Equal(resultado, resultadoIMC);
        }
    }
}
