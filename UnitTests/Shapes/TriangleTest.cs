using System;
using NUnit.Framework;
using Shapes;

namespace UnitTests.Shapes
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]

        [TestCase(-5, 5, 6, TestName = "Стороны = -5")]
        public void NotPositiveLegsTest(int legA, int legB, int legC)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(legA, legB, legC));
            Assert.That(ex.Message, Is.EqualTo("Длина стороны не может быть отрицательной!"));
        }
        
        [TestCase(0, 0, 0, TestName = "Стороны = 0")]
        public void ZeroLegsTest(int legA, int legB, int legC)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(legA, legB, legC));
            Assert.That(ex.Message, Is.EqualTo("Длина стороны не может быть равна нулю!"));
        }

        //[TestCase(5, 5, 10, TestName = "Сторона С = А + B")]
        //public void LegABiggerThanBPlusCTest(int legA, int legB, int legC)
        //{
        //    var ex = Assert.Throws<ArgumentException>(() => new Triangle(legA, legB, legC));
        //    Assert.That(ex.Message, Is.EqualTo("Длина стороны не может быть больше или равна сумме двух других!"));
        //}

        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, TestName = "Стороны = int.MaxValue")]
        public void MaxLegsTest(int legA, int legB, int legC)
        {
            Assert.DoesNotThrow(() => new Triangle(legA, legB, legC));
        }
        
        [TestCase(5, 6, 8, TestName = "Square if legs = 5, 6, 8")]
        public void SquareTest(int legA, int legB, int legC)
        {
            var triangle = new Triangle(legA, legB, legC);
            double p = (legA + legB + legC) / 2.0; //half of perimiter
            Assert.AreEqual(Math.Sqrt(p * (p - legA) * (p - legB) * (p - legC)), triangle.Square);
        }
    }
}