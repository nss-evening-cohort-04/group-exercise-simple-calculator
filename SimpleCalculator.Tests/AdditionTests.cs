using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void CheckCreatingInstanceOfAddition()
        {
            Addition additionNumber = new Addition();
            Assert.IsNotNull(additionNumber);
        }

        [TestMethod]
        public void CheckAdditionMethod()
        {
            Addition additionNumber = new Addition();

            int expectedResult = 9;
            int actualResult = additionNumber.AddNumbers(5, 4);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
