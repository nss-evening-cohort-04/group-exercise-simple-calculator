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
        static void Main(string[] args)
        {

            Dictionary<string, int> myConstants = new Dictionary<string, int>();

            int counter = 0;
            string myOperator = " ";
            string command = "", firstOp = "", secondOp = "";
            int firstOpNum, secondOpNum;
            START:


            Console.WriteLine($"[{counter}]>");
            command = Console.ReadLine();
            var commandKyes = Expression.getMathExpression(command);
            Console.WriteLine(commandKyes[0]);
            firstOp = commandKyes[0];
            myOperator = commandKyes[1];
            secondOp = commandKyes[2];
            bool isNumeric1 = int.TryParse(firstOp, out firstOpNum);
            bool isNumeric2 = int.TryParse(secondOp, out secondOpNum);


            Console.ReadLine();


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
                    Console.WriteLine($"   = saved "{firstOp}" as "{secondOpNum}"");
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
            else if (isNumeric1 && isNumeric2)
            {
                var myCalculator = new Calculator();
                switch (myOperator)
                {
                    case "=":
                        myCalculator.Add(firstOpNum, secondOpNum);
                        break;
                    case "+":
                        myCalculator.Add(firstOpNum, secondOpNum);
                        break;
                    case "-":
                        myCalculator.Subtract(firstOpNum, secondOpNum);
                        break;
                    case "/":
                        myCalculator.Divide(firstOpNum, secondOpNum);
                        break;
                    case "*":
                        myCalculator.Multiply(firstOpNum, secondOpNum);
                        break;
                    case "%":
                        myCalculator.Modulus(firstOpNum, secondOpNum);
                        break;
                    default:
                        break;
                }
            }
            counter++;

        }
    }
}
