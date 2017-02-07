using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Constants
    {
        private string newConstantName;
        private int newConstantValue;
        private Dictionary<string, int> constants = new Dictionary<string, int>();
        public string fullConstant;
        public string addConstant(string userInput)
        {
            Match c = Regex.Match(userInput, @"(?<Constant>\w+)\s*([=])\s*(?<Value>\d+)");
            if (c.Success)
            {
                newConstantName = c.Groups["constantName"].Value.ToString();
                newConstantValue = int.Parse(c.Groups["constantValue"].Value);
                constants.Add(newConstantName, newConstantValue);
                return fullConstant = $"= saved { newConstantName } as { newConstantValue }";
            }
            return "Constat didn't store, try again";
         }
    }
}
