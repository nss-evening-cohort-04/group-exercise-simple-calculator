using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ModulusTests
    {
        [TestMethod]
        public void CheckCreatingInstanceOfModulus()
        {
            Modulus modulus = new Modulus();
            Assert.IsNotNull(modulus);
        }

        [TestMethod]
        public void CheckModulusMethod()
        {
            Modulus modulus = new Modulus();
            int expectedResult = 1;
            int actualResult = modulus.ModulusNumbers(3, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
