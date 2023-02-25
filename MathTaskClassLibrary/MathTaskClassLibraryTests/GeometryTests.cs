using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.CalculateArea(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateAreaInvalidDataTest1()
        {
            bool catched = false;
            try
            {
                int a = -4;
                int b = 10;
                Geometry g = new Geometry();
                g.CalculateArea(a, b);
            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработаны допустимые данные");
        }
        public void CalculateAreaInvalidDataTest2()
        {
           
                int a = -4;
                int b = 10;
                Geometry g = new Geometry();
                g.CalculateArea(a, b);
           
            Assert.ThrowsException<ArgumentException>(() =>g.CalculateArea(a,b), "не обработаны допустимые данные");
        }
    }
}
