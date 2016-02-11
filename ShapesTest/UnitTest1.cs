using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FSLCodeExercise.Start;

namespace ShapesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquareType()
        {
            var shape = FactoryShape.Create(ShapeType.Square, 5);

            Assert.IsInstanceOfType(shape, typeof(Square));
        }

        [TestMethod]
        public void TestCircleType()
        {
            var shape = FactoryShape.Create(ShapeType.Circle, 5);

            Assert.IsInstanceOfType(shape, typeof(Circle));
        }

        [TestMethod]
        public void TestEquilateralTriangleType()
        {
            var shape = FactoryShape.Create(ShapeType.EquilateralTriangle, 5);

            Assert.IsInstanceOfType(shape, typeof(EquilateralTriangle));
        }

        [TestMethod]
        public void TestSquareArea()
        {
            var shape = FactoryShape.Create(ShapeType.Square, 5);

            Assert.AreEqual(shape.Area, 25);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            var shape = FactoryShape.Create(ShapeType.Circle, 5);

            Assert.AreEqual(shape.Area, 78.54);
        }

        [TestMethod]
        public void TestEquilateralTriangleArea()
        {
            var shape = FactoryShape.Create(ShapeType.EquilateralTriangle, 5);

            Assert.AreEqual(shape.Area, 10.83);
        }
    }
}
