using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_tp;

namespace TesteUnitario
{
    [TestClass]
    public class TesteCalculadora
    {
        Calculadora calc = new Calculadora { a = 20, b = 10 };
        [TestMethod]
        public void TesteSoma()
        {
            Assert.AreEqual(calc.Soma, 30);
        }

        [TestMethod]
        public void TesteDiferenca()
        {
            Assert.AreEqual(calc.Diferenca, 10);
        }

        [TestMethod]
        public void TesteProduto()
        {
            Assert.AreEqual(calc.Produto, 200);
        }

        [TestMethod]
        public void TesteDivisao()
        {
            Assert.AreEqual(calc.Divisao, 2);
        }
    }
}