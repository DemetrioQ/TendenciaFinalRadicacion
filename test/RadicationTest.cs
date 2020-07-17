using NUnit.Framework;
using Radication;

namespace test
{
    public class Tests
    {

        [Test]
        public void Constructor_With_Valid_Potency()
        {
            Assert.That(() => new Radicacion(2),Throws.Nothing);
        }
    }
}