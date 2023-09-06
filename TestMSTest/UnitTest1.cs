global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Schema;
using Teste_Opera��es;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            // Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(10, 5, 15)]
        [DataRow(20, 2, 22)]
        [DataRow(2, 3, 5)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);
            
        }
    }
}