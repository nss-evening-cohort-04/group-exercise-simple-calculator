using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class DivisionTests
    {

        [TestMethod]
        public void CheckCreatingInstanceOfDivision()
        {
            Division divisionNumber = new Division();
            Assert.IsNotNull(divisionNumber);
        }

        [TestMethod]
        public void CheckDivisionMethod()
        {
            Division divisionNumber = new Division();

            double expectedResult = 5;
            double actualResult = divisionNumber.DivideNumbers(15, 3);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
