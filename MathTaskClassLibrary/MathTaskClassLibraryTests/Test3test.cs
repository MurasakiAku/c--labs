using System;
using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Test3test
    {
        [TestMethod]
        public void Test3Method()
        {
            Test3 zadanie3 = new Test3();
            int year = 2000;
            int expected = 366;
            int actual = zadanie3.test3(year);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test3Method1()
        {
            Test3 zadanie3 = new Test3();
            int year = 2001;
            int expected = 365;
            int actual = zadanie3.test3(year);
            Assert.AreEqual(expected, actual);
        }
    }
}
