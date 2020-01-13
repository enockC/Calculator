﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{

    [TestClass()]
    public class RandomisingTests
    {
        private readonly int min = 10;
        private readonly int max = 30;
        private readonly Randomising random = new Randomising(2);
        [TestMethod()]
        public void RandomiseTest()
        {
            //Assert.IsTrue();
            Assert.AreEqual(random.GenerateRandomNumber(min, max), random.GenerateRandomNumber(min, max));
        }
    }
}
