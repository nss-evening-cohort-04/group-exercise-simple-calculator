using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluateTests
    {
        Evaluate TestEvaluate = new Evaluate();

        [TestMethod]
        public void CanIAdd()
        {
            Evaluate myEvaluate = new Evaluate();
            int theAnswer = myEvaluate.Add(3, 4);
            Assert.AreEqual(theAnswer, 7);
        }
        [TestMethod]
        public void CanISubtract()
        {
            Evaluate myEvaluate = new Evaluate();
            int theAnswer = myEvaluate.Subtract(7, 3);
            Assert.AreEqual(theAnswer, 4);
        }

        [TestMethod]
        public void EnsureInstanceOfEvaluate()
        {
            Assert.IsNotNull(TestEvaluate);
        }

        [TestMethod]
        public void EnsureCanMultiply()
        {
            int a = 3;
            int b = 4;

            Assert.AreEqual(TestEvaluate.Multiply(a, b), 12);
        }

        [TestMethod]
        public void EnsureCanDivide()
        {
            int a = 6;
            int b = 3;

            Assert.AreEqual(TestEvaluate.Divide(a, b), 2);
        }

        [TestMethod]
        public void EnsureCanModulus()
        {
            int a = 5;
            int b = 2;

            Assert.AreEqual(TestEvaluate.Modulus(a, b), 1);
        }
    }
}
