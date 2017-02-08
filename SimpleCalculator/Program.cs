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
            Console.WriteLine("You can also define constants to use in your expressions. ( x = 1 )");
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
                        int firstTerm = 0;
                        int secondTerm = 0;
                        if (!parser.Operator.Equals('!'))
                        {
                            if (parser.Operator.Equals('='))
                            {
                                try
                                {
                                    constants.Add(char.Parse(parser.FirstTerm.ToLower()), int.Parse(parser.SecondTerm));
                                }
                                catch (ArgumentException)
                                {
                                    Console.WriteLine($"A constant with key \"{parser.FirstTerm}\" already exists.");
                                }
                            }
                            else
                            {
                                if (parser.FirstTerm.Length > 1)
                                {
                                    if (parser.SecondTerm.Length > 1)
                                    {
                                        firstTerm = int.Parse(parser.FirstTerm);
                                        secondTerm = int.Parse(parser.SecondTerm);
                                    }
                                    else
                                    {
                                        firstTerm = int.Parse(parser.FirstTerm);
                                        if (constants.ContainsKey(char.Parse(parser.SecondTerm)))
                                        {
                                            secondTerm = constants[char.Parse(parser.SecondTerm)];
                                        }
                                        else
                                        {
                                            secondTerm = int.Parse(parser.SecondTerm);
                                        }

                                    }

                                }
                                else if (parser.SecondTerm.Length > 1 && parser.FirstTerm.Length == 1)
                                {

                                    if (constants.ContainsKey(char.Parse(parser.FirstTerm)))
                                    {
                                        firstTerm = constants[char.Parse(parser.FirstTerm)];
                                    }
                                    else
                                    {
                                        firstTerm = int.Parse(parser.SecondTerm);
                                    }

                                    secondTerm = int.Parse(parser.SecondTerm);
                                }
                                else if (constants.ContainsKey(char.Parse(parser.FirstTerm.ToLower())) && constants.ContainsKey(char.Parse(parser.SecondTerm)))
                                {
                                    firstTerm = constants[char.Parse(parser.FirstTerm.ToLower())];
                                    secondTerm = constants[char.Parse(parser.SecondTerm)];
                                }
                                else if (constants.ContainsKey(char.Parse(parser.FirstTerm.ToLower())))
                                {
                                    firstTerm = constants[char.Parse(parser.FirstTerm.ToLower())];
                                    secondTerm = int.Parse(parser.SecondTerm);
                                }
                                else if (constants.ContainsKey(char.Parse(parser.SecondTerm)))
                                {
                                    firstTerm = int.Parse(parser.FirstTerm);
                                    secondTerm = constants[char.Parse(parser.SecondTerm.ToLower())];
                                }
                                else
                                {
                                    firstTerm = int.Parse(parser.FirstTerm);
                                    secondTerm = int.Parse(parser.SecondTerm);
                                }
                                int calculatedResult = evaluate.Calculate(firstTerm, secondTerm, parser.Operator); //test code -- fix when parser updated
                                stack.LastAnswer = calculatedResult;
                                Console.WriteLine($" = {calculatedResult}");
                            }
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
