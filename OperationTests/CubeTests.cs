using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 12;
        private readonly double b = 13.2;

        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(1728, Cube.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(2299.968, Cube.Cubed(b));
        }
    }
}
