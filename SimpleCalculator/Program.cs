using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            ////// foundational elements
            Parser parser = new Parser();
            Evaluate evaluate = new Evaluate();
            Stack stack = new Stack();
            List<string> Escape = new List<string>() { "quit", "exit", "escape" }; // exit commands

            while (true)
            {
                // ask the user for a basic mathematical equation
                Console.WriteLine("Please type a basic expression you would like me to find the answer to.");
                Console.WriteLine("Include one of the following operators: + - * / %");

                string userInput = Console.ReadLine();

                if (userInput == "lastq")
                {
                    stack.setLastQuery(parser.LastExpression);
                }

                if (Escape.Contains(userInput))
                {
                    Environment.Exit(0);
                } else if (userInput == "lastq")
                {
                    Console.WriteLine($"Last question: { stack.LastQuery }");
                }
                else if (userInput == "lasta")
                {
                    Console.WriteLine($"Last answer: { stack.LastAnswer }");
                }
                else
                {                   
                    // do the math
                    try
                    {
                        int calculatedResult = evaluate.Calculate(1, 1, '+'); //"sample/"test code -- fix when parser updated
                        Console.WriteLine(calculatedResult);
                        stack.setLastAnswer(calculatedResult);
                        Console.WriteLine("Type lastq for the last statement or type lasta for the last answer");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Sorry, { userInput } is not a valid request.");
                        Console.WriteLine("Try again, something more simple like: 2 + 1. Take it easy on me");
                    }
                }
                
            }
        }
    }
}
