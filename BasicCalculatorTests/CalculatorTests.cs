using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;


namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Add(100, 221);

            Assert.AreEqual(321, c);
            Assert.AreEqual(321, calculator.result);

        }
        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Divide(2, 1);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calculator.result);

        }
    }
}