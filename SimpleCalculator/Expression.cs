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

        public Expression()
        {
            Operator = "";
            leftValue = "";
            rightValue = "";
        }

        public static string[] getMathExpression(string arg)
        {

            Regex r = new Regex(@"^.*[+\/\-%*=]+.*$", RegexOptions.IgnoreCase);
            Match m = r.Match(arg);
            if (m.Success)
            {
                // has operator
                r = new Regex(@"^(?<value1>\w+)\s*(?<operator>[+\/\-%*=])\s*(?<value2>\w+)\s*$", RegexOptions.IgnoreCase);
                m = r.Match(arg);
                if (m.Success)
                {
                    var temporaryInstance = new Expression();
                    temporaryInstance.leftValue = (string)m.Groups["value1"].Value;
                    temporaryInstance.Operator = m.Groups["operator"].Value;
                    temporaryInstance.rightValue = (string)m.Groups["value2"].Value;
                    return new string[] { temporaryInstance.leftValue, temporaryInstance.Operator, temporaryInstance.rightValue };
                }
            }
            else
            {
                // has no operator
                r = new Regex(@"^\s*\w+\s*$", RegexOptions.IgnoreCase);
                m = r.Match(arg);
                if (m.Success)  return new string[] { arg.Trim() };
            }
            return new string[] { "invalid" };
        }
    }
}