using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while(true)
            {
                Console.WriteLine($"[{x}]>");
                // increment number of times using program
                x++;
                // user passed expression
                string input = Console.ReadLine();
                if (input.ToLower() == "quit" || input.ToLower() == "exit")
                {
                    break;
                }

                Regex r1 = new Regex(@"(\d+)\s*([+-/%*])\s*(\d+)");

                // Match the input and write results
                Match match = r1.Match(input);
                if (match.Success)
                {
                    string firstValue = match.Groups[1].Value;
                    string operatorUsed = match.Groups[2].Value;
                    string secondValue = match.Groups[3].Value;

                    Console.WriteLine("First value = {0}", firstValue);
                    Console.WriteLine("Operator =  {0}", operatorUsed);
                    Console.WriteLine("Second value =  {0}", secondValue);
                }
                else
                {
                    Console.WriteLine("Please enter in the formatt of (1 + 1) or (1+1)");
                }
            }
        }
    }
}
