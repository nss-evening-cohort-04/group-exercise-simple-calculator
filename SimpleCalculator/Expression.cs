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
        
        public string Operator { get; set; }
        public string leftValue { get; set; }
        public string rightValue { get; set; }
        //string pattern = ;
       //public string input = "2+2";

        public Expression()
        {
            Operator = "";
            leftValue = "";
            rightValue = "";
        }

        public static string[] getMathExpression(string arg)
        {
            Console.WriteLine("Expression Class.");

            Regex r = new Regex(@"^(?<number1>\w+)\s*(?<operator>[+\/\-%*]+)\s*(?<number2>\w+)\s*$", RegexOptions.IgnoreCase);

            //Match m = r.Match("2+2");
            Match m = r.Match(arg);


            if (m.Success)
            {
                var temporaryInstance = new Expression();
                temporaryInstance.leftValue = (string)m.Groups["number1"].Value;
                temporaryInstance.Operator = m.Groups["operator"].Value;
                temporaryInstance.rightValue = (string)m.Groups["number2"].Value;
                return new string[] {temporaryInstance.leftValue, temporaryInstance.Operator, temporaryInstance.rightValue };
            }else
            {
                return new string[] { };
            }

        }
}
}
