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
        public string FirstTerm { get; set; }
        public string SecondTerm { get; set; }
        public char Operator { get; set; }

        public void ParseInput(string input)
        {
            try
            {
                string pattern = @"\b([a-zA-Z]\b|\d+)\s*([\+\-*\/%\=]{1})\s*\b([a-zA-Z]\b|\d+)";

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    FirstTerm = match.Groups[1].Value;
                    Operator = char.Parse(match.Groups[2].Value);
                    SecondTerm = match.Groups[3].Value;
                }
                else
                {
                    throw new ArgumentException("Bad Expression entered.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Operator = '!';
            }

        }
    }
}
