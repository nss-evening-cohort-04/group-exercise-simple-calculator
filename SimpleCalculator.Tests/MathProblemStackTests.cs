using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MathProblemStackTests
    {
        [TestMethod]
        public void CheckCreatingStack()
        {
            MathProblemStack mathProblems = new MathProblemStack();
            Assert.IsNotNull(mathProblems);
        }

        [TestMethod]
        public void CheckAddNewProblemMethod()
        {
            MathProblemStack mathProblems = new MathProblemStack();
            mathProblems.addNewMathProblem("2 + 2");
            

            string expectedResult = "2 + 2";
            string actualResult = mathProblems.Stack.Peek().ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckReturnLastProblemMethod()
        {
            MathProblemStack mathProblems = new MathProblemStack();
            mathProblems.addNewMathProblem("2 + 2");
            mathProblems.addNewMathProblem("7 + 9");

            string expectedResult = "7 + 9";
            string actualResult = mathProblems.getLastMathProblem();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
