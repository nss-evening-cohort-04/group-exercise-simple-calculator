using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantTest
    {
        [TestMethod]
        public void CheckInstance()
        {
            ConstantStorage constant = new ConstantStorage();
            Assert.IsNotNull(constant);
        }

    }
}
