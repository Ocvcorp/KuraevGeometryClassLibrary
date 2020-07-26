using NUnit.Framework;
using KuraevGeometryClassLibrary;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCalcTriangle()
        {
           Triangle2D t = new Triangle2D(3, 4, 5);
            double area = t.Area;
            Assert.
        }
    }
}