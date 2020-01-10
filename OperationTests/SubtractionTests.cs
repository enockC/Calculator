using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.Tests
    
{
   
    public class SubtractionTests
    {
        
        private readonly int a = 10;
        private readonly int b = 5;
        private readonly double c = 20.3;
        private readonly double d = 10.2;
       

        [TestMethod()]
        public void SubtractionTest()
        {
            Assert.AreEqual(5, Subtraction.Subtract(a, b));
        }

        public void SubtractionDoubleTest()
        {
            Assert.AreEqual(10.1, Subtraction.Subtract(c, d));
        }

        
        

    }
}
    
