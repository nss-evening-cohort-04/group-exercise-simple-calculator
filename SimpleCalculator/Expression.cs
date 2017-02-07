using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        //Evaluate eval = new Evaluate();
        public readonly int Operand1;
        public readonly int Operand2;
        public readonly char Operation;

        public Expression(int operandOne, int operandTwo, char operation)
        {
            if (operandOne < 1 || operandTwo < 1)
            {
                throw new ArgumentException("I can only evaluate positive numbers.");
            }
            else
            {
                Operand1 = operandOne;
                Operand2 = operandTwo;
            }

            if ("+-*/%".IndexOf(operation) == -1)
            {
                throw new ArgumentException("Nope, sorry. I can not perform this action. Try again.");
            }
            else
            {
                Operation = operation;
            }
        }
    }
}
