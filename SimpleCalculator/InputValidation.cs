using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class InputValidation
    {
        Dictionary<string, int> myConstants = new Dictionary<string, int>();
        int counter = 0;
        char myOperator = ' ';
        string command = "", firstOp = "", secondOp = "";
        int firstOpNum, secondOpNum;
        bool isNumeric1 = int.TryParse(firstOp, out firstOpNum);
        bool isNumeric2 = int.TryParse(secondOp, out secondOpNum);
        var pattern = @"(\w+)[+-*/=]\w*";
        //START:


        Console.WriteLine($"[{counter}]>");
            //var pattern = @"\[(.*?)\](.*)";
            //var match = Regex.Match("ignored [john] John Johnson", pattern);
            command = Console.ReadLine();
            var match = Regex.Matches(command, pattern);
        Console.WriteLine(match.Groups[0].Captures[1]);
            //command = Console.ReadLine();

            /*
            if (Char.IsLetter(firstOp, 0) && firstOp.Length == 1)
            {
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
                    Console.WriteLine($"   = saved '{firstOp}' as '{secondOpNum}'");
                    myConstants.Add(firstOp, secondOpNum);

                }
            }
            else if (Char.IsLetter(firstOp, 0) && firstOp.Length > 1)
            {
                // exit or quit or last or lastq
                switch (firstOp)
                {
                    case "exit":
                    case "quit":
                        Environment.Exit(0);
                        break;
                    case "last":
                        break;
                    case "lastq":
                        break;
                    default:
                        counter++;
                        goto START;
                }
            }
            else if ()
            {
                var myCalculator = new Calculator();
                switch (myOperator)
                {
                    case '=':
                        myCalculator.Add(firstOpNum, secondOpNum);
                        break;
                    case '+':
                        myCalculator.Add(firstOpNum, secondOpNum);
                        break;
                    case '-':
                        myCalculator.Subtract(firstOpNum, secondOpNum);
                        break;
                    case '/':
                        myCalculator.Divide(firstOpNum, secondOpNum);
                        break;
                    case '*':
                        myCalculator.Multiply(firstOpNum, secondOpNum);
                        break;
                    case '%':
                        myCalculator.Modulus(firstOpNum, secondOpNum);
                        break;
                    default:
                        break;
                }
            }
            counter++;
            */
        }
}
}
