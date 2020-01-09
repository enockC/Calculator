using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private int a = 10;
        private int b = 20;


        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(30, Addition.Sum(a, b));
        }
    }
}