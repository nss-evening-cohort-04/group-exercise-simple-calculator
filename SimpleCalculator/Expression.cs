using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {


        string expressionPattern = @"^\b(?<FirstNum>\d+)\s*(?<Operator>[\+\/\-\*\%])\s*\b(?<SecondNum>\d+)";
        string constantPattern = @"^\b(?<ConstKey>[a-z])\s*(?<Equals>[=])\s*\b(?<ConstValue>\d+)";

        public string Operator { get; set; }
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public string Constant { get; set; }
        public string ConstantEquals { get; set; }
        public int Value { get; set; }
    
        public void VerifyExpression(string userInput)
        {
            /*string expressionString = @"^\b(?<FirstNum>[a-z]|\d+)\s*(?<Operator>[\+\/\-\*\%])\s*\b(?<SecondNum>\d+)";*/
            Regex expressionRegEx = new Regex(expressionPattern);
            Regex constantRegEx = new Regex(constantPattern);

            Match expMatch = expressionRegEx.Match(userInput);
            Match constMatch = constantRegEx.Match(userInput);

            if (expMatch.Success)
            {
                FirstNum = int.Parse(expMatch.Groups["FirstNum"].Value);
                Operator = expMatch.Groups["Operator"].Value.ToString();
                SecondNum = int.Parse(expMatch.Groups["SecondNum"].Value);

            }
            else if (constMatch.Success)
            {
                Constant = constMatch.Groups["ConstKey"].ToString();
                ConstantEquals = constMatch.Groups["Equals"].Value;
                Value = int.Parse(constMatch.Groups["ConstValue"].Value);
            }
            //else
            //{
            //    Console.WriteLine("That isn't a valid expression. Please try again.");
            //}
        }

    }
}
