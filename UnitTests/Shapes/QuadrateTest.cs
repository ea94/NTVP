using System;
using NUnit.Framework;
using Shapes;

namespace UnitTests.Shapes
{
    [TestFixture]
    public class QuadrateTest
    {
        [Test]

        [TestCase(-5, -5, TestName = "Стороны = -5")]
        public void NotPositiveSidesTest(int sideA, int sideB)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Quadrate(sideA, sideB));
            Assert.That(ex.Message, Is.EqualTo("Длина стороны не может быть отрицательной!"));
        }

        [TestCase(0, 0, TestName = "Стороны = 0")]
        public void ZeroSidesTest(int sideA, int sideB)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Quadrate(sideA, sideB));
            Assert.That(ex.Message, Is.EqualTo("Длина стороны не может быть равна нулю!"));
        }

        [TestCase(int.MaxValue, int.MaxValue, TestName = "Стороны = int.MaxValue")]
        public void MaxSidesTest(int sideA, int sideB)
        {
            Assert.DoesNotThrow(() => new Quadrate(sideA, sideB));
        }

        [TestCase(5, 5, TestName = "Square if sides = 5")]
        public void SquareTest(int sideA, int sideB)
        {
            var quadrate = new Quadrate(sideA, sideB);
            Assert.AreEqual(25, quadrate.Square);
        }
    }
}