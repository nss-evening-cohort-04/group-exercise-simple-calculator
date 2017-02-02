using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("[" + counter + "]");
            string userMathProblem = Console.ReadLine();
            Match m = Regex.Match(userMathProblem, @"(?<mathA>\w+)\s+(?<mathOper>[\ *xX%\/\-\+])\s+(?<mathB>\w+)");
            if (m.Success)
            {
                string mathA = m.Groups["mathA"].Value.ToString();
                string mathOper = m.Groups["mathOper"].Value.ToString();
                string mathB = m.Groups["mathB"].Value.ToString();
                Console.WriteLine(mathA + mathOper + mathB);
            }
            else
            {
                Console.WriteLine("Invalid math problem, please tryagain...");
            }

            Console.ReadLine();
        }
    }
}
