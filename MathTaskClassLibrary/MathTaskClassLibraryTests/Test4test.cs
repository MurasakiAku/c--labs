using System;
using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Test4test
    {
        [TestMethod]
        public void Test4Method0()
        {
            Test4 zadanie4 = new Test4();
            string email = "tasty@tasty";
            
            bool expected = true;
            
            bool actual = zadanie4.test4(email);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test4Method1()
        {

            string email = "tastytasty";

            bool expected = false;
            Test4 zadanie4 = new Test4();
            bool actual = zadanie4.test4(email);
            Assert.AreEqual(expected, actual);

        }
      
        
    }
}
