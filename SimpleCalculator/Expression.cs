using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        public string mathOperator { get; set; }
        public int mathFactorA { get; set; }
        public int mathFactorB { get; set; }
        public Expression()
        {
            mathOperator = null;
            mathFactorA = 0;
            mathFactorB = 0;
        }
        
        public string verifyUserMathProblem (string userMathProblem)
        {
                Match m = Regex.Match(userMathProblem, @"(?<mathA>\d+)\s*(?<mathOper>[\*%\/\-\+\=])\s*(?<mathB>\d+)");
                if (m.Success)
                {
                    mathFactorA = int.Parse(m.Groups["mathA"].Value);
                    mathOperator = m.Groups["mathOper"].Value.ToString();
                    mathFactorB = int.Parse(m.Groups["mathB"].Value);
                }
                return "success";
        }
    }
}
