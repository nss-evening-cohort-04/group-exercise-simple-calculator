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
            Subtraction subtraction = new Subtraction();
            Assert.IsNotNull(subtraction);
        }

        [TestMethod]
        public void EnsureSubtWorking()
        {
            Subtraction subtraction = new Subtraction();
            int expectedResult = 1;
            int actualResult = subtraction.SubtractNumbers(3, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
