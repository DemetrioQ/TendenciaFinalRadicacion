using NUnit.Framework;
using Radication;
using System;

namespace test
{
    public class Tests
    {
        [Test]
        public void DoRadicacion_With_Invalid_Number_Throws_Argument_Exception()
        {
            Assert.That(() => new Radicacion().DoRadicacion("five", "2"), Throws.ArgumentException);
        }

        [Test]
        public void DoRadicacion_With_Invalid_potency_Throws_Argument_Exception()
        {
            Assert.That(() => new Radicacion().DoRadicacion("5", "two"), Throws.ArgumentException);
        }

        [Test]
        public void DoRadication_With_Valid_Values_Throws_Nothing()
        {
            Assert.That(() => new Radicacion().DoRadicacion("4", "2"), Throws.Nothing);
        }

        [Test]
        public void DoRadication_With_0_As_Potency_Throws_Argument_Exxeptio()
        {
            Assert.That(() => new Radicacion().DoRadicacion("4", "0"), Throws.ArgumentException);
        }

        [Test]
        public void DoRadicacion_With_Even_Number_As_Pottency_And_Negaty_Number_Throws_Argument_Exception()
        {
            Assert.That(() => new Radicacion().DoRadicacion("-2", "2"), Throws.ArgumentException);
        }

        [Test]
        public void DoRadicacion_With_2_As_Potency_And_16_As_Value_Returns_4()
        {
            Assert.That(() => new Radicacion().DoRadicacion("16", "2"), Is.EqualTo(4));
        }

        [Test]
        public void DoRadicacion_With_Any_Number_As_Potency_And_0_As_Value_Returns_0()
        {
            Assert.That(() => new Radicacion().DoRadicacion("0", "2"), Is.EqualTo(0));
        }



        [Test]
        public void DoRadicacion_With_Minus2_As_Potency_And_25_As_Value_Returns_0_dot_25()
        {
            Assert.That(() => new Radicacion().DoRadicacion("16", "-2"), Is.EqualTo(0.25));
        }










    }
}