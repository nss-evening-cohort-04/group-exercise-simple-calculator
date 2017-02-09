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

            Storage storage = new Storage();
            int counter = 0;
            string myOperator = "";
            string currentCommand = "", firstOp = "", secondOp = "";
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
                    Console.WriteLine(storage.last);
                    break;
                case "lastq":
                    Console.WriteLine(storage.lastq);
                    break;
                case "getConstant":
                    if (Storage.myConstants.ContainsKey(firstOp))
                    {
                        Console.WriteLine(Storage.myConstants[firstOp]);
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
                            if (Storage.myConstants.ContainsKey(firstOp))
                            {
                                Console.WriteLine("   = Error!");
                            }
                            else
                            {
                                Console.WriteLine($"   = saved '{firstOp}' as '{secondOpNum}'");
                                Storage.myConstants[firstOp] = secondOpNum;
                            }
                            break;
                        case "calculate":
                            if (!isNumeric1)
                            {
                                if (Storage.myConstants.ContainsKey(firstOp))
                                {
                                    firstOpNum = Storage.myConstants[firstOp];
                                }
                                else
                                {
                                    Console.WriteLine($"   Constant '{firstOp}' not exist!");
                                }
                            }
                            if (!isNumeric2)
                            {
                                if (Storage.myConstants.ContainsKey(secondOp))
                                {
                                    secondOpNum = Storage.myConstants[secondOp];
                                }
                                else
                                {
                                    Console.WriteLine($"   Constant '{secondOp}' not exist!");
                                }
                            }
                            calcResult = Calculator.calculate(firstOpNum, secondOpNum, myOperator);
                            storage.last = calcResult;
                            Console.WriteLine(calcResult);
                            break;
                    }
                    break;
            }
            if (currentCommand.ToLower() != "last" && currentCommand.ToLower() != "lastq")
            {
                storage.lastq = currentCommand;
            }
            counter++;
            goto START;

            END:
            Console.WriteLine("Bye!");

        }
    }
}
