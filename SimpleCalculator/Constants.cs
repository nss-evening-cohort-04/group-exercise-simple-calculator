using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Constants
    {
        private string NewConstantName;
        private int NewConstantValue;
        private Dictionary<string, int> constants = new Dictionary<string, int>();

        public string addConstant (string userInput)
        {
            Match m = Regex.Match(userInput, @"(?<constantName>\w+)\s*([\=])\s*(?<constantValue>\d+)");
            if (m.Success)
            {
                NewConstantName = m.Groups["constantName"].Value.ToString();
                NewConstantValue = int.Parse(m.Groups["constantValue"].Value);
                constants.Add(NewConstantName, NewConstantValue);
                return "= saved " + NewConstantName + " as " + NewConstantValue;
            }
            return "failed to save constant";
        }

        //public int getValue (string userinput)
        //{
        //    if (constants.ContainsKey(userinput))
        //    {
        //        uservalue = constants[userinput];
        //    }
        //}
    }
}
