using System;
using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Test5test
    {
        [TestMethod]
        public void Test5Method1()
        {
            Test5 zadanie5 = new Test5();
            
            int expected = 10;
            int actual = zadanie5.test5("55");
          //  int expected = 10;
            Assert.AreEqual(expected, actual);
        }
    }
}
