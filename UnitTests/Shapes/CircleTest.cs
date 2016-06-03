using System;
using Moq;
using NUnit.Framework;
using Shapes;

namespace UnitTests.Shapes
{
    [TestFixture]
    public class CircleTest
    {
        [Test]

        [TestCase(-5, TestName = "Радиус = -5")]
        public void NotPositiveRadiusTest(int radius)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));
            Assert.That(ex.Message, Is.EqualTo("Радиус не может быть отрицательным!"));
        }

        [TestCase(0, TestName = "Радиус = 0")]
        public void ZeroRadiusTest(int radius)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));
            Assert.That(ex.Message, Is.EqualTo("Радиус не может быть равен нулю!"));
        }

        [TestCase(int.MaxValue, TestName = "Радиус = int.MaxValue")]
        public void MaxRadiusTest(int radius)
        {
            Assert.DoesNotThrow(() => new Circle(radius));
        }

        [TestCase(5, TestName = "Square if radius = 5")]
        public void SquareTest(int radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.Round(Math.PI, 2) * Math.Pow(radius, 2) / 2, circle.Square);
            //Assert.DoesNotThrow(() => new Circle(radius));
            //Assert.That(ex.Message, Is.EqualTo("Радиус не может быть равен нулю!"));
        }

        //[Test]
        //public void MockTest()
        //{
        //    var tt = new Mock<IShape>();
        //    tt.Setup()
        //    tt.VerifyGet(p => p.Square);
        //}
    }
}