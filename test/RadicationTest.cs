using NUnit.Framework;
using Radication;

namespace test
{
    public class Tests
    {

        [Test]
        public void Constructor_With_Valid_Potency()
        {
            Assert.That(() => new Radicacion(2), Throws.Nothing);
        }

        [Test]
        public void Constructor_With_0_As_Potency_Throws_Argument_Exxeptio()
        {
            Assert.That(() => new Radicacion(0), Throws.ArgumentException);
        }

        [Test]
        public void DoRadicacion_With_Even_Number_As_Pottency_And_Negaty_Number_Throws_Argument_Exception()
        {
            Assert.That(() => new Radicacion(2).DoRadicacion(-2), Throws.ArgumentException);
        }

        [Test]
        public void DoRadicacion_With_2_As_Potency_And_16_As_Value_Returns_4()
        {
            Assert.That(() => new Radicacion(2).DoRadicacion(16), Is.EqualTo(4));
        }

        [Test]
        public void DoRadicacion_With_Any_Number_As_Potency_And_0_As_Value_Returns_0()
        {
            Assert.That(() => new Radicacion(2).DoRadicacion(0), Is.EqualTo(0));
        }










    }
}