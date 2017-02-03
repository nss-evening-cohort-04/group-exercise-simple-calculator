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
            int counter = 0;

            Console.Write("[" + counter + "]");
            string userMathProblem = Console.ReadLine();
            Expression userExpression = new Expression();
            userExpression.verifyUserMathProblem(userMathProblem);
            Console.WriteLine(userExpression.mathFactorA);
            Console.WriteLine(userExpression.mathOperator);
            Console.WriteLine(userExpression.mathFactorB);

            string operationUsed = userExpression.mathOperator;
            string description = "Operation used: ";

            switch (operationUsed)
            {
                case "+":
                    Console.WriteLine(description + operationUsed);
                    break;

                case "-":
                    Console.WriteLine(description + operationUsed);
                    break;

                case "*":
                    Console.WriteLine(description + operationUsed);
                    break;

                case "/":
                    Console.WriteLine(description + operationUsed);
                    break;

                case "%":
                    Console.WriteLine(description + operationUsed);
                    break;

                default:
                    Console.WriteLine("Please select a valid operation");
                    break;
            }

            Console.ReadLine();

        }

    }
}
