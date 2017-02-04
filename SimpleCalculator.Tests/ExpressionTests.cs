using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    public class ExpressionTests
    {
        [TestMethod]
        public void TestExpressionClassExist()
        {
            Expression expressionInstance = new Expression();
            Assert.IsNotNull(expressionInstance);
        }

        [TestMethod]
        public void EnsureGetMathExpressionIsCorrect()
        {
            //Arrange
            Expression expressionInstance = new Expression();
            //Act
            string[] expectedResult = new string[] {"2","+","2"};
            string[] actualResult = Expression.getMathExpression("2+2");
            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
