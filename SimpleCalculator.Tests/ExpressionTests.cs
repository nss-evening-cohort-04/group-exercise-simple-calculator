using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void TestCanIMakeSomething()
        {
            Expression exp = new Expression();
            Assert.IsNotNull(exp);
        }

        [TestMethod]
        public void TestWritingAProblemWithCorrectInput()
        {
            Expression exp = new Expression(3, 6, '-');
            Assert.AreEqual(3, exp.Operand1);
            Assert.AreEqual('-', exp.Operation);
            Assert.AreEqual(6, exp.Operand2);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestCalculatingWithBadOperationInput()
        {
            Expression exp = new Expression(3, 6, 'x');
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestCalculatingWithBadOperatorInput()
        {
            Expression exp = new Expression(-5, -1, '*');
        }

    }
    
}