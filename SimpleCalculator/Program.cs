using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Parser parser = new Parser();
            Stack stack = new Stack();
            Dictionary<char, int> constants = new Dictionary<char, int>();

        // initialize Evaluator HERE
        Evaluate evaluate = new Evaluate();
            int counter = 0;

            List<string> Escape = new List<string>() { "quit", "exit", "escape", "stop" }; // exit commands
            string lastq = "lastq";
            string lastanswer = "last";

            // ask the user for a basic mathematical equation
            Console.WriteLine("Please type a basic expression you would like me to find the answer to.");
            Console.WriteLine("Include one of the following operators: + - * / %.");
            Console.WriteLine("Get your last answer by typing last");
            Console.WriteLine("Get your last question by typing lastq");
            Console.WriteLine("Exit at anytime by typing exit / quit / escape / stop");

            while (true)
            {

                string userInput = ConsoleReadLineWithDefault($"[{counter}]> ");
                counter++;
                if (Escape.Contains(userInput))
                {
                    Console.WriteLine("Bye!!");
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else if (userInput.Equals(lastq))
                {
                    // lastq from stack
                    Console.WriteLine(stack.LastQuery);
                }
                else if (userInput.Equals(lastanswer))
                {
                    // calls lastanswer from stack
                    Console.WriteLine(stack.LastAnswer);
                }
                else
                {
                    //evaluate input
                    try
                    {
                        // send user input to parser function=
                        stack.LastQuery = userInput;
                        parser.ParseInput(userInput);
                        if (!parser.Operator.Equals('!'))
                        {
                            int calculatedResult = evaluate.Calculate(parser.FirstTerm, parser.SecondTerm, parser.Operator); //test code -- fix when parser updated
                            stack.LastAnswer = calculatedResult;
                            Console.WriteLine($" = {calculatedResult}");            
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, { userInput } is not a valid request.");
                            Console.WriteLine("Try again, something more simple like: 2 + 1. Take it easy on me");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Sorry, { userInput } is not a valid request.");
                        Console.WriteLine("Try again, something more simple like: 2 + 1. Take it easy on me");
                    }
                }
            }
        }

        public static string ConsoleReadLineWithDefault(string defaultValue)
        {
            Console.Write(defaultValue);
            return Console.ReadLine();
        }
    }
}
