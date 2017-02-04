using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Parser parser = new Parser();
            var actualValue = parser.ParseInput("1 + 1");
            Assert.IsInstanceOfType(actualValue, typeof(Expression));

        }

        [TestMethod]
        public void Test2()
        {
            /*Parser parser = new Parser();
            string expectedValue = "last";
            var actualValue = parser.ParseInput("last");
            Assert.AreEqual(actualValue, expectedValue);*/
        }
    }
}
