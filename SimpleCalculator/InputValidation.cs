using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputValidation
    {
        public static string validateCommand(string[] args)
        {
            string myOperator = "";
            string firstOp = "", secondOp = "";
            int firstOpNum, secondOpNum;
            firstOp = args[0];
            bool isNumeric1 = int.TryParse(firstOp, out firstOpNum);
            if (args.Length == 1)
            {
                if (!isNumeric1 && firstOp.Length > 1)
                {
                    switch (firstOp)
                    {
                        case "exit":
                        case "quit":
                            return "exit";
                        case "last":
                            return "last";
                        case "lastq":
                            return "lastq";
                        default:
                            return "invalid";
                    }
                }
                else if (!isNumeric1 && firstOp.Length == 1)
                {
                    return "getConstant";
                }
                else return "invalid";
            }
            else
            {
                myOperator = args[1];
                secondOp = args[2];
                bool isNumeric2 = int.TryParse(secondOp, out secondOpNum);

                if (myOperator == "=")
                {
                    if (Char.IsLetter(firstOp, 0) && firstOp.Length == 1 && isNumeric2)
                    {
                        return "saveConstant";
                    }
                    else return "invalid";
                }
                else
                {
                    if ((!isNumeric1 && firstOp.Length > 1) || (!isNumeric2 && secondOp.Length > 1))
                    {
                        return "invalid";
                    }
                    else return "calculate";
                }
            }
        }
    }
}
