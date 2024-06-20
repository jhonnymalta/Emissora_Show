using Emissora_Tv_Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emissora.Tests
{

    [TestFixture]
    internal class ClienteTests
    {
        private Cliente cliente;

        [SetUp]
        public void Setup()
        {
            cliente = new Cliente();
        }


        [Test]
        public void CriarIdentificadorCliente()
        {            

            string result = cliente.CriarIdentificadorCliente("Ben", "Callman");

            Assert.That(result, Is.EqualTo("@BenCallman123"));
            Assert.That(result, Does.Contain("@"));
            Assert.That(result, Does.EndWith("123"));

        }
    }
}
