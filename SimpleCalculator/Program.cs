using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            StackStorage mathStack = new StackStorage();
            ConstantStorage varStore = new ConstantStorage();

            while (true)
            {
                Console.Write($"[{counter}]> ");

                string Command = Console.ReadLine();

                if (Command.ToLower() == "quit" || Command.ToLower() == "exit")
                {
                    Environment.Exit(0);
                }
                else if ( Command == "last")
                {
                    Command = mathStack.getLastProblem();
                }
                else if (Command == "lastq")
                {
                    Console.WriteLine("last problem was " + mathStack.getLastProblem());
                }
                
                //initalize regex expression
                Expression expression = new Expression();
                expression.VerifyExpression(Command);
                int firstNum = expression.FirstNum;
                int secondNum = expression.SecondNum;
                string Operator = expression.Operator;

                string userMathExpression = (firstNum + Operator + secondNum).ToString();

                string constant = expression.Constant;
                string equals = expression.ConstantEquals;
                int value = expression.Value;

                string constantExpression = (constant + equals + value).ToString();

                //adds the user input into addMathToStack and makes it a string
                mathStack.addMathToStack(userMathExpression);
                
                //switch statement for calculations
                switch (Operator)
                {
                    case "+":
                        Calculator calcAdd = new Calculator();
                        Console.WriteLine("   = " + calcAdd.Add(firstNum, secondNum));
                        break;

                    case "-":
                        Calculator calcSubtract = new Calculator();
                        Console.WriteLine("   = " + calcSubtract.Subtract(firstNum, secondNum));
                        break;
                            
                    case "*":
                        Calculator calcMultiply = new Calculator();
                        Console.WriteLine("   = " + calcMultiply.Multiply(firstNum, secondNum));
                        break;

                    case "/":
                        Calculator calcDivide = new Calculator();
                        Console.WriteLine("   = " + calcDivide.Divide(firstNum, secondNum));
                        break;

                    case "%":
                        Calculator calcModulus = new Calculator();
                        Console.WriteLine("   = " + calcModulus.Modulus(firstNum, secondNum));
                        break;

                    default:
                        break;
                }
                counter++;
            }
        }
    }
}
