using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{
    [TestClass()]
    public class RandomisingTests
    {
        private readonly int min = 12;
        private readonly int max = 24;
        Randomising rand = new Randomising();
        Randomising rand1 = new Randomising();

        [TestMethod()]
        public void RandomiseTest()
        {
            Assert.AreEqual(rand.Randomise(min, max), rand1.Randomise(min, max));
        }
    }
}