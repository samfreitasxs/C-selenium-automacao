using NUnit.Framework;
using TestProject1.Page;

namespace TestProject1.Test
{
    public class ValidaCepTest : ValidaCepPage
    {
        [Test]
        public void ValidaCep() 
        {

            PreencheCep();
            ClicaBtnBusca();
            ValidaResultado();
        }

        [Test]
        public void ValidarResultadoTotal()
        {

            PreencheCep();
            ClicaBtnBusca();
            ValidaResultadoTotal();
        }

        [Test]
        public void ValidaMultiplosCenarios()
        {
            ValidaMultiplosCeps();
        }
    }
}
