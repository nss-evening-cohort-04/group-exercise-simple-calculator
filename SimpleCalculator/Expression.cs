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
        public decimal mathFactorA { get; set; }
        public decimal mathFactorB { get; set; }
        public Expression()
        {
            mathOperator = null;
            mathFactorA = 0;
            mathFactorB = 0;
        }
        
        public void verifyUserMathProblem (string userMathProblem)
        {
            Match m = Regex.Match(userMathProblem, @"(?<mathA>\w+)?\s*(?<mathOper>[\ *xX%\/\-\+])?\s*(?<mathB>\w+)");
            if (m.Success)
            {
                mathFactorA = int.Parse(m.Groups["mathA"].Value);
                mathOperator = m.Groups["mathOper"].Value.ToString();
                mathFactorB = int.Parse(m.Groups["mathB"].Value);
            }
        }
    }
}
