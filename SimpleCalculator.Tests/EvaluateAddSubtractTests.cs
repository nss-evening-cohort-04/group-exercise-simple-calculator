using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluateAddSubtract
    {
        //A?
        [TestMethod]
        public void CanICreateAnEvaluate()
        {
            Evaluate myEvaluate = new Evaluate();
            Assert.IsNotNull(myEvaluate);
        }
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
    }
}
