using System;
using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Test1test
    {
        [TestMethod]
        public void Test1Method1()
        {
            Test1 zadanie1 = new Test1();
            string expected = "ABCDE";
            string actual = zadanie1.test1(5);
            Assert.AreEqual(expected, actual);
        }
    }
}
