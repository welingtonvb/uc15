using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteIMC;

namespace TestMSTest
{
    [TestClass]

    public class ClassificarIMC_MSTest
    {
        [TestMethod]    

        public void Classificar()
        {
            double imc = 28;

            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}
