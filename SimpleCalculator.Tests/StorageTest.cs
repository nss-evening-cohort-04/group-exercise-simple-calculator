using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StorageTest
    {
        [TestMethod]
        public void TestInstance()
        {
            StackStorage stack = new StackStorage();
            Assert.IsNotNull(stack);
        }

        [TestMethod]
        public void CheckIfAddingToStack()
        {
            StackStorage stack = new StackStorage();

            stack.addMathToStack("4 + 3");

            string expectedResult = "4 + 3";
            string actualResult = stack.Stack.Peek().ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckGetLast()
        {
            StackStorage stack = new StackStorage();

            stack.addMathToStack("4 + 3");
            stack.addMathToStack("23 + 23");

            string expectedResult = "23 + 23";
            string actualResult = stack.getLastProblem();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
