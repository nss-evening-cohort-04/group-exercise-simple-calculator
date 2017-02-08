using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void TestFindAddition()
        {
            Parser parser = new Parser();
            parser.ParseInput("2 + 2");
            Assert.AreEqual(2, parser.FirstTerm);
            Assert.AreEqual(2, parser.SecondTerm);
            Assert.AreEqual('+', parser.Operator);
        }

        [TestMethod]
        public void TestFindSubtraction()
        {
            Parser parser = new Parser();
            parser.ParseInput("1212-2");
            Assert.AreEqual(1212, parser.FirstTerm);
            Assert.AreEqual(2, parser.SecondTerm);
            Assert.AreEqual('-', parser.Operator);
        }

        [TestMethod]
        public void TestFindMultiply()
        {
            Parser parser = new Parser();
            parser.ParseInput("2 * 211");
            Assert.AreEqual(2, parser.FirstTerm);
            Assert.AreEqual(211, parser.SecondTerm);
            Assert.AreEqual('*', parser.Operator);
        }

        [TestMethod]
        public void TestFindDivide()
        {
            Parser parser = new Parser();
            parser.ParseInput("2/12");
            Assert.AreEqual(2, parser.FirstTerm);
            Assert.AreEqual(12, parser.SecondTerm);
            Assert.AreEqual('/', parser.Operator);
        }

        [TestMethod]
        public void TestFindModulo()
        {
            Parser parser = new Parser();
            parser.ParseInput("23 % 2");
            Assert.AreEqual(23, parser.FirstTerm);
            Assert.AreEqual(2, parser.SecondTerm);
            Assert.AreEqual('/', parser.Operator);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBadAddition()
        {
            Parser parser = new Parser();
            parser.ParseInput("+2");
        }

        [TestMethod]
        public void TestAssigningConstant()
        {
            Parser parser = new Parser();
            parser.ParseInput("x=1");
            Assert.AreEqual('x', parser.FirstTerm);
            Assert.AreEqual(1, parser.SecondTerm);
            Assert.AreEqual('=', parser.Operator);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBadConstantAssignment()
        {
            Parser parser = new Parser();
            parser.ParseInput("1=x");
        }
    }
}
