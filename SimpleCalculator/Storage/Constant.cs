using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Constant
    {
        public Dictionary<string, int> Constants = new Dictionary<string, int>();

        public void verifyConstant(string constantCreationAttempt)
        {
            Match m = Regex.Match(constantCreationAttempt, @"(?<constantName>[a-zA-Z]+)\s*([\=])\s*(?<constantValue>[0-9]+)");
            if (m.Success)
            {
                string constantName = m.Groups["constantName"].Value.ToString();
                int constantValue = int.Parse(m.Groups["constantValue"].Value);
                if (Constants.ContainsKey(constantName.ToLower()))
                {
                    Constants[constantName.ToLower()] = constantValue;
                    Console.WriteLine("   = " + constantName + " is now " + constantValue);
                }
                else
                {
                    Constants.Add(constantName.ToLower(), constantValue);
                    Console.WriteLine("   = saved " + constantName + " as " + constantValue);
                }
            }
        }

        public void getConstant(string retrievingContant)
        {
            retrievingContant = retrievingContant.ToLower();
            if (Constants.ContainsKey(retrievingContant))
            {
                int value = Constants[retrievingContant];
                Console.WriteLine("   = " + value);
            }
            else
            {
                Console.WriteLine("   = " + retrievingContant + " has not been defined.");
            }
        }

        public string updateMathProblemWithConstants(string userMathProblem)
        {
            string newProblem = "";
            foreach (var constant in Constants)
                newProblem = Constants.Aggregate(userMathProblem, (result, s) => result.Replace(s.Key, s.Value.ToString()));
            if (newProblem.ToLower() == userMathProblem.ToLower() || Constants.Count == 0)
            {
                Console.WriteLine("   = Error: undefined constant present in equation.");
            }
            return newProblem;
        }
    }
}
