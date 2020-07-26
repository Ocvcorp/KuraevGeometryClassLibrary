using KuraevGeometryClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace UnitTestGeometry
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestCalcTriangle()
        {
            Triangle2D t = new Triangle2D(3, 4, 5);

            double area = t.Area;
            Assert.AreEqual(6, area);
        }
    }
}
