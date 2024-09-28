using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Lab01;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
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
}
