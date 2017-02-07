using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleCalculator;

namespace SimpleCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<string, int> myConstants = new Dictionary<string, int>();

            int counter = 0;
            string myOperator = "";
            string currentCommand = "", previousCommand = "", firstOp = "", secondOp = "";
            int firstOpNum, secondOpNum, calcResult = 0;

            START:
            Console.WriteLine($"[{counter}]>");
            currentCommand = Console.ReadLine();
            var commandKeys = Expression.getMathExpression(currentCommand);
            var action = InputValidation.validateCommand(commandKeys);
            firstOp = commandKeys[0];
            bool isNumeric1 = int.TryParse(firstOp, out firstOpNum);
            switch (action)
            {
                case "invalid":
                    Console.WriteLine("Invalid command");
                    break;
                case "exit":
                    goto END;
                case "last":
                    Console.WriteLine(calcResult);
                    break;
                case "lastq":
                    Console.WriteLine(previousCommand);
                    break;
                case "getConstant":
                    if (myConstants.ContainsKey(firstOp))
                    {
                        Console.WriteLine(myConstants[firstOp]);
                    }
                    else
                    {
                        Console.WriteLine($"   Constant '{firstOp}' not exist!");
                    }
                    break;
                default:
                    myOperator = commandKeys[1];
                    secondOp = commandKeys[2];
                    bool isNumeric2 = int.TryParse(secondOp, out secondOpNum);
                    switch (action)
                    {
                        case "saveConstant":
                            if (myConstants.ContainsKey(firstOp))
                            {
                                Console.WriteLine("   = Error!");
                            }
                            else
                            {
                                Console.WriteLine($"   = saved '{firstOp}' as '{secondOpNum}'");
                                myConstants[firstOp] = secondOpNum;
                            }
                            break;
                        case "calculate":
                            if (!isNumeric1)
                            {
                                if (myConstants.ContainsKey(firstOp))
                                {
                                    firstOpNum = myConstants[firstOp];
                                }
                                else
                                {
                                    Console.WriteLine($"   Constant '{firstOp}' not exist!");
                                }
                            }
                            if (!isNumeric2)
                            {
                                if (myConstants.ContainsKey(secondOp))
                                {
                                    secondOpNum = myConstants[secondOp];
                                }
                                else
                                {
                                    Console.WriteLine($"   Constant '{secondOp}' not exist!");
                                }
                            }
                            calcResult = Calculator.calculate(firstOpNum, secondOpNum, myOperator);
                            Console.WriteLine(calcResult);
                            break;
                    }
                    break;
            }
            previousCommand = currentCommand;
            counter++;
            goto START;

            END:
            Console.WriteLine("Bye!");

        }
    }
}
