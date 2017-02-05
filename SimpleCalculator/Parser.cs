using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parser
    {
       
        public Expression ParseInput(string input)
        {
            var LastExpression = input;
            char[] operators = new char[] { '+', '-', '*', '%', '/' };
            try
            {
                string[] splitStr = input.Trim().Split(operators);
                int firstTerm = -1;
                int secondTerm = -1;
                char mathOperator = 'a';
                if (splitStr.Length > 1)
                {
                    firstTerm = int.Parse(splitStr[0].Trim());
                    mathOperator = input[splitStr[0].Length];
                    secondTerm = int.Parse(splitStr[1].Trim());
                };
                    
                return new Expression(firstTerm, secondTerm, mathOperator);
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
