using Emissora_Tv_Api;
using NUnit.Framework;

namespace Emissora_Tv.Tests
{
    [TestFixture]
    public class Calculator_Test
    {
        [Test]
        public void Soma_Test()
        {
            Calculator calculator = new Calculator();

            double result = calculator.Soma(10, 30);

            Assert.Equals(40, result);
        }
    }
}
