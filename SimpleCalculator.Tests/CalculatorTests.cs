using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestCalculatorExist()
        {
            Calculator calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void TestAddition()
        {
            Calculator calculator = new Calculator();
            int expected = 5;
            int actual = calculator.Add(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSbutraction()
        {
            Calculator calculator = new Calculator();
            int expected = 5;
            int actual = calculator.Subtract(8, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivision()
        {
            Calculator calculator = new Calculator();
            int expected = 5;
            int actual = calculator.Divide(15, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Calculator calculator = new Calculator();
            int expected = 15;
            int actual = calculator.Multiply(5, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestModulus()
        {
            Calculator calculator = new Calculator();
            int expected = 2;
            int actual = calculator.Modulus(5, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
