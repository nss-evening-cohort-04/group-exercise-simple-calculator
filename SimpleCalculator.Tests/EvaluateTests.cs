using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluateTests
    {

        [TestMethod]
        public void EnsureInstanceOfEvaluate()
        {
            Evaluate TestEvaluate = new Evaluate();
            Assert.IsNotNull(TestEvaluate);
        }

        [TestMethod]
        public void CanIAdd()
        {
            Evaluate myEvaluate = new Evaluate();
            int theAnswer = myEvaluate.Add(13, 4);
            Assert.AreEqual(theAnswer, 17);
        }

        [TestMethod]
        public void CanISubtract()
        {
            Evaluate myEvaluate = new Evaluate();
            int theAnswer = myEvaluate.Subtract(7, 3);
            Assert.AreEqual(theAnswer, 4);
        }

        [TestMethod]
        public void EnsureCanMultiply()
        {
            Evaluate myEvaluate = new Evaluate();
            int theAnswer = myEvaluate.Multiply(3, 10);
            Assert.AreEqual(theAnswer, 30);
        }

        [TestMethod]
        public void EnsureCanDivide()
        {
            Evaluate myEvaluate = new Evaluate();
            int theAnswer = myEvaluate.Divide(10, 5);
            Assert.AreEqual(theAnswer, 2);
        }

        [TestMethod]
        public void EnsureCanModulus()
        {
            Evaluate myEvaluate = new Evaluate();
            int theAnswer = myEvaluate.Modulus(5, 2);
            Assert.AreEqual(theAnswer, 1);
        }
    }
}
