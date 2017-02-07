using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CanIMakeStack()
        {
            Stack myStack = new Stack();
            Assert.IsNotNull(myStack);
        }
        [TestMethod]
        public void CanISetLastQuery()
        {
            //Assert
            Stack myStack = new Stack();
<<<<<<< HEAD
            myStack.LastQuery = ("2 + 2");
=======
            string lastq = ("2 + 2");
>>>>>>> fc38c5a5e81d5612ac8c6b59e435770471a653c0
            Assert.AreEqual(myStack.LastQuery, ("2 + 2"));
        }
        [TestMethod]
        public void CanISetLastAnswer()
        {
            Stack myStack = new Stack();
<<<<<<< HEAD
            myStack.LastAnswer = 4;
            Assert.AreEqual(myStack.LastAnswer, 4);
=======
            string lastanswer = "4";
            Assert.AreEqual(myStack.LastAnswer, "4");
>>>>>>> fc38c5a5e81d5612ac8c6b59e435770471a653c0
        }
    }
}
