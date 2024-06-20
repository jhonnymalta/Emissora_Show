using Emissora_Tv_Api;

namespace Emissora.Tests
{
    
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Soma()
        {
            Calculator calc = new Calculator();

            double result = calc.Soma(10,20);

            Assert.AreEqual(30, result);
        }
        [Test]
        [TestCase(10.4,20.20)] //210.08
        [TestCase(50.10,50.10)] //2510.01
        public void Multiplicacao(double a,double b)
        {
            Calculator calc = new Calculator();

            double result = calc.Multiplicacao(a, b);

            Assert.AreEqual(2510.01, result,1);
        }
    }
}