using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class SubtractionTests
    {
        [TestMethod]
        public void EnsureSubtNotNull()
        {
            Multiplication multiplication = new Multiplication();
            Assert.IsNotNull(multiplication);
        }

        [TestMethod]
        public void EnsureSubtWorking()
        {
            Multiplication multiplication = new Multiplication();
            int expectedResult = 2 * 3;
            int actualResult = multiplication.Multiply(2, 3);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
