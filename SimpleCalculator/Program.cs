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
            int calculatedResult = evaluate.Calculate(parser.Operand1, parser.Operand2, parser.Operation);

            while (true)
            {
                // ask the user for a basic mathematical equation
                Console.WriteLine("Please type a basic expression you would like me to find the answer to.");
                Console.WriteLine("Include one of the following operators: + - * /.");
                string userInput = Console.ReadLine();

                //evaluate input
                try
                {
                    // send user input to parser function
                    string calculatorAnswer = ""; // the result of the evaluate functions is stored in this variable
                    Console.WriteLine(calculatorAnswer);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Sorry, { userInput} is not a valid request.");
                    Console.WriteLine("Try again, something more simple like: 2 + 1. Take it easy on me");
                }
            }
        }
    }
}
