using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> mathProblems = new List<string>();

            Console.WriteLine("WELCOME TO THE SIMPLE CALCULATOR! Type exit or quit to close the application." + Environment.NewLine);
            int counter = 1;
            bool userDoingMath = true;
            while (userDoingMath)
            {
                Console.Write("[" + counter + "]  ");
                string userMathProblem = Console.ReadLine();
                if (userMathProblem.ToLower() == "quit" || userMathProblem.ToLower() == "exit")
                {
                    userDoingMath = false;
                    Environment.Exit(0);
                }
                else if (userMathProblem == "last")
                {
                    userMathProblem = mathProblems[mathProblems.Count() - 1];
                }
                else if (userMathProblem == "lastq")
                {
                    Console.WriteLine(mathProblems[mathProblems.Count() - 1]);
                }
                Expression userExpression = new Expression();
                userExpression.verifyUserMathProblem(userMathProblem);
                int mathFactorA = userExpression.mathFactorA;
                int mathFactorB = userExpression.mathFactorB;
                string operationUsed = userExpression.mathOperator;

                if (mathFactorA != 0 && operationUsed != null && mathFactorB != 0)
                {
                    mathProblems.Add(mathFactorA + operationUsed + mathFactorB);
                }
                switch (operationUsed)
                {
                    case "+":
                        Addition addNumbers = new Addition();
                        Console.WriteLine("   = " + addNumbers.AddNumbers(mathFactorA, mathFactorB));
                        break;

                    case "-":
                        Subtraction subtractNumbers = new Subtraction();
                        Console.WriteLine("   = " + subtractNumbers.SubtractNumbers(mathFactorA, mathFactorB));
                        break;

                    case "*":
                        Multiplication multiplyNumbers = new Multiplication();
                        Console.WriteLine("   = " + multiplyNumbers.MultiplyNumbers(mathFactorA, mathFactorB));
                        break;

                    case "/":
                        Division divideNumbers = new Division();
                        Console.WriteLine("   = " + divideNumbers.DivideNumbers(mathFactorA, mathFactorB));
                        break;

                    case "%":
                        //Console.WriteLine(description + operationUsed);
                        break;

                    default:
                        break;
                }
                counter++;

            }

        }

    }
}
