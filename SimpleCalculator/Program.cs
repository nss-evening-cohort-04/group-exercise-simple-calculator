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

            // Dictionary<string, int> myConstants = new Dictionary<string, int>();

            int counter = 0;
            string myOperator = " ";
            string currentCommand = "", previousCommand = "", firstOp = "", secondOp = "";
            int firstOpNum, secondOpNum, calcResult = 0;

            START:
            Console.WriteLine($"[{counter}]>");
            currentCommand = Console.ReadLine();
            var commandKeys = Expression.getMathExpression(currentCommand);
            firstOp = commandKeys[0];
            bool isNumeric1 = int.TryParse(firstOp, out firstOpNum);

            if(commandKeys.Length == 1)

            {
                Console.WriteLine(firstOp);
                if (!isNumeric1 && firstOp.Length > 1)
                {
                    // exit or quit or last or lastq
                    switch (firstOp)
                    {
                        case "exit":
                        case "quit":
                            // Environment.Exit(0);
                            goto END;
                        case "last":
                            Console.WriteLine(calcResult);
                            break;
                        case "lastq":
                            Console.WriteLine(previousCommand);
                            break;
                        default:
                            break;
                    }
                    counter++;
                    previousCommand = currentCommand;
                    goto START;
                }

                else
                {
                    // if not stored , then store
                    Console.WriteLine($"   = saved {firstOp}as {secondOpNum}");
                    myConstants.Add(firstOp, secondOpNum);

                }

            }
            else
            {
                myOperator = commandKeys[1];
                secondOp = commandKeys[2];
                bool isNumeric2 = int.TryParse(secondOp, out secondOpNum);


                if ((Char.IsLetter(firstOp, 0) && firstOp.Length == 1) || (Char.IsLetter(secondOp, 0) && secondOp.Length == 1))
                {
                    // perform constant operation
                    /*
                    if (myConstants.ContainsKey(firstOp))
                    {
                        // if stored, error msg, ready for command
                        Console.WriteLine("   = Error!");
                        counter++;
                        goto START;
                    }
                    else
                    {
                        // if not stored , then store
                        Console.WriteLine($"   = saved \"{firstOp}\" as \"{secondOpNum}\"");
                        myConstants.Add(firstOp, secondOpNum);

                    }
                    */
                }
                else if (isNumeric1 && isNumeric2)
                {
                    var myCalculator = new Calculator();
                    switch (myOperator)
                    {
                        case "+":
                            calcResult = myCalculator.Add(firstOpNum, secondOpNum);
                            break;
                        case "-":
                            calcResult = myCalculator.Subtract(firstOpNum, secondOpNum);
                            break;
                        case "/":
                            calcResult = myCalculator.Divide(firstOpNum, secondOpNum);
                            break;
                        case "*":
                            calcResult = myCalculator.Multiply(firstOpNum, secondOpNum);
                            break;
                        case "%":
                            calcResult = myCalculator.Modulus(firstOpNum, secondOpNum);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(calcResult);
                }
                counter++;
                previousCommand = currentCommand;
                goto START;

            }


            END:
            Console.WriteLine("Bye!");

        }
    }
}
