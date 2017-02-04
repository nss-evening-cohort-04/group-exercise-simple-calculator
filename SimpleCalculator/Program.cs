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
            // initialize Parser HERE
            Parser parser = new Parser();

            // initialize Evaluator HERE
            Evaluate evaluate = new Evaluate();

            List<string> Escape = new List<string>() { "quit", "exit", "escape" }; // exit commands
            string lastq = "lastq";
            string lastanswer = "last";


                while (true)
            {
                // ask the user for a basic mathematical equation
                Console.WriteLine("Please type a basic expression you would like me to find the answer to.");
                Console.WriteLine("Include one of the following operators: + - * /.");
                string userInput = Console.ReadLine();

                if (Escape.Contains(userInput))
                {
                    Environment.Exit(0);
                } else if (userInput.Equals(lastq))
                {
                    // lastq from stack
                } else if (userInput.Equals(lastanswer))
                {
                    // calls lastanswer from stack
                } else
                {
                    //evaluate input
                    try
                    {
                        // send user input to parser function
                        int calculatedResult = evaluate.Calculate(1, 1, '+'); //test code -- fix when parser updated
                        Console.WriteLine(calculatedResult);
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
