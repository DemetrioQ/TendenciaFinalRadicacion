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

        [Test]
        public void DoRadicacion_With_Even_Number_As_Pottency_And_Negaty_Number_Throws_Exception()
        {
            Assert.That(() => new Radicacion(2).DoRadicacion(-2),Throws.ArgumentException);
        }
    }
}