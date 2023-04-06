using System;
using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Test2test
    {
        [TestMethod]
        public void Test2Method1()
        {
            
            double a = 1;
            double b = -3;
            double c = 5;
            double[] expected = { -1, 4 };
            Test2 zadanie2 = new Test2();
            double[] actual = zadanie2.test2(a,b,c);
            CollectionAssert.AreEqual(expected,actual);
           //Assert.AreEqual(expected, actual);

        }
    }
}
