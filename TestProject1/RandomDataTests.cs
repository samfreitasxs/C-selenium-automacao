using System;
using NUnit.Framework;
using TestProject1.Core;

namespace TestProject1
{
    public class RandomDataTests : DSL
    {
        [Test]
        public void RandomData()
        {

            string nome = GeraNomeAleatorio();
            Console.WriteLine(nome);

            string email = GeraEmailAleatorio();
            Console.WriteLine(email);

            string dataNasc = GeraDataNascimento();
            Console.WriteLine(dataNasc);

            string cel = GeraCelularAleatorio();
            Console.WriteLine(cel);
        }
    }
}
