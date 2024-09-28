using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Lab01;

namespace TestProject1
{
    [TestClass]
    public class RectangleTest
    {
        private const double expected_area = 30;
        private const double expected_periemter = 22;
        [TestMethod]
        public void TestArea()
        {
            Rectangle rect = new Rectangle(5.0, 6.0);
            Assert.AreEqual(rect.Area, expected_area);
        }
        [TestMethod]
        public void TestPeriemter()
        {
            Rectangle rect = new Rectangle(5.0, 6.0);
            Assert.AreEqual(rect.Perimeter, expected_periemter);
        }
            
    }

    [TestClass]
    public class FigureTest
    {
        private const string expected_name = "rect";
        private const double expected_perimeter = 4;
        [TestMethod]
        public void TestPerimeterCalculation()
        {
            Figure test_fig = new Figure([new Point(1.0, 0.0), new Point(2.0, 0.0), new Point(3.0, 0.0)]);
            Assert.AreEqual(test_fig.PerimeterCalculator(), expected_perimeter);
        }
        [TestMethod]
        public void TestName()
        {
            Figure test_fig = new Figure([new Point(1.0, 0.0), new Point(2.0, 0.0), new Point(3.0, 0.0)]);
            test_fig.Name = "rect";
            Assert.AreEqual(test_fig.Name, expected_name);
        }
    }
}
