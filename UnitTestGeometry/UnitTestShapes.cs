using KuraevGeometryClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using System;
using Assert = NUnit.Framework.Assert;

namespace UnitTestGeometry
{
    [TestClass]
    public class UnitTestShapes
    {
        [TestMethod]
        public void TestCalcTriangle()
        {
            //right triangle
            Triangle2D t1 = new Triangle2D(3, 4, 5);
            double area = t1.GetArea();
            bool isRectangular = t1.IsRectangular;
            Assert.AreEqual(6, area);
            Assert.AreEqual(true, isRectangular);

            //non-rectangular triangle
            Triangle2D t2 = new Triangle2D(5, 5, 8);
            area = t2.GetArea();
            isRectangular = t2.IsRectangular;
            Assert.AreEqual(12, area);
            Assert.AreEqual(false, isRectangular);
            
            //incorrect input
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<Exception>(() => new Triangle2D(5, 10, 5));
        }
        [TestMethod]
        public void TestCircle()
        {
            Circle2D c1 = new Circle2D(1);
            double area = c1.GetArea();
            Assert.AreEqual(Math.PI, area);
        }

        [TestMethod]
        public void GetAreas()
        {
            //area caclulation without type
            Shape2D[] shapes = {
                new Triangle2D(3, 4, 5),
                new Circle2D(2),
                new Circle2D(3),
                new Triangle2D(8, 12, 6)
            };
            
            //area sum calculation
            double areaSum = .0;
            foreach (var sh in shapes)
                areaSum += sh.GetArea();
            Assert.AreEqual(68.17, Math.Round(areaSum, 2));
        }   
    }
}
