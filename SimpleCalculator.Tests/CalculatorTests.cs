using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests

    {
        [TestMethod]
        public void TestInstance()
        {
            Calculator calc = new Calculator();
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        public void additionTest()
        {
            Calculator calcAdd = new Calculator();

            int expectedResult = 4;
            int actualResult = calcAdd.Add(2, 2);

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void subtractionTest()
        {
            Calculator calcSubtract = new Calculator();

            int expectedResult = 8;
            int actualResult = calcSubtract.Subtract(10, 2);

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void multiplyTest()
        {
            Calculator multiply = new Calculator();

            int expectedResult = 16;
            int actualResult = multiply.Multiply(2, 8);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void divideTest()
        {
            Calculator calcDivide = new Calculator();

            int expectedResult = 4;
            int actualResult = calcDivide.Divide(8, 2);

            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void modulusTest()
        {
            Calculator calcModulus = new Calculator();

            int expectedResult = 0;
            int actualResult = calcModulus.Modulus(6, 2);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
