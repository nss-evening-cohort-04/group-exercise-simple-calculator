using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class ConstantCreator
    {
        public Dictionary<string, int> Constants = new Dictionary<string, int>();
        public void verifyConstant(string constantCreationAttempt)
        {
            Match m = Regex.Match(constantCreationAttempt, @"(?<constantName>[a-z]+)\s*([\=])\s*(?<constantValue>[0-9]+)");
            if (m.Success)
            {
                string constantName = m.Groups["constantName"].Value.ToString();
                int constantValue = int.Parse(m.Groups["constantValue"].Value);
                if (Constants.ContainsKey(constantName))
                {
                    Constants[constantName] = constantValue;
                    Console.WriteLine("  = updated " + constantName + " to " + constantValue);
                }
                else
                {
                    Constants.Add(constantName, constantValue);
                    Console.WriteLine("   = saved " + constantName + " as " + constantValue);
                }
            }
        }

        public void getConstant(string constant)
        {
            int value = Constants[constant];
            Console.WriteLine("   = " + value);
        }

        public string updateMathProblemWithConstants(string userMathProblem)
        {
            string newProblem = "";
            foreach (var constant in Constants)
                newProblem = Constants.Aggregate(userMathProblem, (result, s) => result.Replace(s.Key, s.Value.ToString()));
            if (newProblem == userMathProblem)
            {
                Console.WriteLine("   = Error: undefined constant present in equation.");
            }
            return newProblem;
        }
    }
}
