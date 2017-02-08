using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantsTests
    {
        [TestMethod]
        public void EnsureConstantsNotNull()
        {
            Constant constant = new Constant();
            Assert.IsNotNull(constant);
        }
        [TestMethod]
        public void EnsureVerifyConstantWorking()
        {
            Constant constant = new Constant();
            string expectedResult = "   = saved x as 15";

            string actualResult = constant.verifyConstant("x = 15");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCanGetConstant()
        {
            Constant constant = new Constant();
            constant.verifyConstant("x = 15");
            int actualResult = constant.getConstant("x");
            Assert.AreEqual(15, actualResult);
        }
        
        [TestMethod]
        public void EnsureCanUpdateMathProblem()
        {
            Constant constant = new Constant();
            constant.verifyConstant("x = 15");
            string actualResult = constant.updateMathProblemWithConstants("x");
            Assert.AreEqual("15" , actualResult);
        }
    }
}
