﻿using System;
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

                Expression expression = new Expression();
                expression.VerifyExpression(Command);
                int firstNum = expression.FirstNum;
                int secondNum = expression.SecondNum;
                string Operator = expression.Operator;
   
                mathStack.addMathToStack((firstNum + Operator + secondNum).ToString());
          
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
