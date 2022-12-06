using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteIMC;

namespace TestMSTest
{

    [TestClass]

    public class CalculoIMC_MSTest
    {
        [TestMethod]
        
        public void CalcularIMC()
        {
            double peso = 118;
            double altura = 1.79;

            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            Assert.AreEqual(36.83, resultadoIMC);
        }
    }
}
