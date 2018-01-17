using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SquareGeometricObject.API;
using SquareGeometricObject.GeometricInterface;
using SquareGeometricObject.GeometricObjects;


namespace SquareGeometricObjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TriangleTest()
        {
            InterfaceObjectSquare obj = new ObjectSquare();
            
            Assert.AreEqual(6, obj.GetSquare(new Triangle(3, 4, 5)));
            Assert.AreEqual(156.318, Math.Round( obj.GetSquare(new Triangle(19, 19, 19)), 3));
            Assert.AreEqual(205.656, Math.Round(obj.GetSquare(new Triangle(15.1, 56.3, 43.7)), 3));
        }

        [TestMethod]
        public void CircleTest()
        {
            InterfaceObjectSquare obj = new ObjectSquare();

            Assert.AreEqual(3.142, Math.Round(obj.GetSquare(new Circle(1)), 3));
            Assert.AreEqual(530.929, Math.Round(obj.GetSquare(new Circle(13)), 3));
            Assert.AreEqual(0.071, Math.Round(obj.GetSquare(new Circle(0.15)), 3));

        }

        [TestMethod]
        [ExpectedException(typeof(System.ArithmeticException))]
        public void ExceptionTest()
        {
            InterfaceObjectSquare obj = new ObjectSquare();

            obj.GetSquare(new Triangle(-1, 2, -3));
            obj.GetSquare(new Triangle(0, 4, 6));
            obj.GetSquare(new Triangle(10, 50, 10));

            obj.GetSquare(new Circle(0));
            obj.GetSquare(new Circle(-5));
        }

    }
}
