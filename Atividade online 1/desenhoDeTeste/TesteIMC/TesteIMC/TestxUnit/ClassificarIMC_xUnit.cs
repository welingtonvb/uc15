using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteIMC;

namespace TestxUnit
{
    public class ClassificarIMC_xUnit
    {

/*
        [Fact]

        public void ClassificarIMC()
        {
            double imc = 28;

            var classificar = Operacoes.ClassificarIMC(imc);

            Assert.Equal("Sobrepeso", classificar);
        }

*/

        [Theory]

        [InlineData(19.53, "Peso normal")]
        [InlineData(25.71, "Sobrepeso")]
        [InlineData(38.06, "Obesidade Grau II")]
        [InlineData(16.61, "Abaixo do peso")]
        [InlineData(46.91, "Obesidade Grau III")]
        [InlineData(33.60, "Obesidade Grau I")]
        [InlineData(22.89, "Peso normal")]

        public void ClassificarIMC_Lista(double imc, string resultado)
        {
            var resultadoIMC = Operacoes.ClassificarIMC(imc);
            Assert.Equal(resultado, resultadoIMC);
        }
    }
}
