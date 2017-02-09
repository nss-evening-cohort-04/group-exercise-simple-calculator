using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        //sanity check test
        [TestMethod]
        public void CanCreateAnInstance()
        {
            Expression expression = new Expression();
            Assert.IsNotNull(expression);
        }

       [TestMethod]
        public void CanCheckInput()
        {
            Expression testExpression = new Expression();
            string testPattern = @"^\b(?<FirstNum>\d+)\s*(?<Operator>[\+\/\-\*\%])\s*\b(?<SecondNum>\d+)";
            Regex Regex = new Regex(testPattern);

            string test1 = "1+1";
            string test2 = "2 + 2";
            string test3 = "nah, bro";
            string test4 = "2 *4";
            string test5 = "1 %2";
            string test6 = "1  /  4";


            Assert.IsTrue(Regex.IsMatch(test1));
            Assert.IsTrue(Regex.IsMatch(test2));
            Assert.IsFalse(Regex.IsMatch(test3));
            Assert.IsTrue(Regex.IsMatch(test4));
            Assert.IsTrue(Regex.IsMatch(test5));
            Assert.IsTrue(Regex.IsMatch(test6));
        }

        [TestMethod]
        public void CanCheckForConstant()
        {
            Expression constantExpression = new Expression();
            string constantPattern = @"^\b(?<ConstKey>[a-z])\s*(?<Equals>[=])\s*\b(?<ConstValue>\d+)";
            Regex constRegEx = new Regex(constantPattern);

            string test1 = "a=1";
            string test2 = "3+2";

            Assert.IsTrue(constRegEx.IsMatch(test1));
            Assert.IsFalse(constRegEx.IsMatch(test2));

        }
    }
}
