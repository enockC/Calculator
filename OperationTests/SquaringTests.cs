using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{
    [TestClass()]
    public class SquaringTests
    {
        private readonly int a = 12;
        private readonly double b = 13.2;

        [TestMethod()]
        public void SquareTest()
        {
            Assert.AreEqual(144, Squaring.Square(a));
        }

        [TestMethod()]
        public void SquareDoubletest()
        {
            Assert.AreEqual(174.23999999999998, Squaring.Square(b));
        }
    }
}