using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void EnsureICanCreateAnExpressionInstance()
        {
            Expression regEx = new Expression();
            Assert.IsNotNull(regEx);
        }

        [TestMethod]
        public void EnsureICanPassMathProblemAndSetValues()
        {
            Expression regex = new Expression();
            string expectedResult = "success";

            string actualResult = regex.verifyUserMathProblem("2  +  1");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanAccessSetValues()
        {
            Expression regex = new Expression();
            int expectedMathAResult = 2;
            int expectedMathBResult = 1;
            string expectedOperator = "+";

            string actualResult = regex.verifyUserMathProblem("2  +  1");
            Assert.AreEqual(expectedMathAResult, regex.mathFactorA);
            Assert.AreEqual(expectedMathBResult, regex.mathFactorB);
            Assert.AreEqual(expectedOperator, regex.mathOperator);
        }
    }
}
