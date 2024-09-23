using NUnit.Framework;
using rascunho;

namespace SomaApp.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Soma_dois_numerosRetorna_Soma()
        {
            int x = 3;
            int y = 4;
            int expected = 7;

            int result = Program.Soma(x, y);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
