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

            char[] operators = new char[] { '+', '-', '*', '%', '/' };
            try
            {
                string[] splitStr = input.Trim().Split(operators);
                string firstTerm = "-1";
                string secondTerm = "-1";
                char mathOperator = 'a';
                if (splitStr.Length > 1)
                {
                    firstTerm = splitStr[0].Trim();
                    mathOperator = input[splitStr[0].Length];
                    secondTerm = splitStr[1].Trim();
                }
                else
                {

                };
                    
                return new Expression(Convert.ToInt32(firstTerm), Convert.ToInt32(secondTerm), Convert.ToChar(mathOperator));
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
