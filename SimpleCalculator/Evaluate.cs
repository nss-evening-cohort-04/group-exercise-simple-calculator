using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCalculator
{
    public class Evaluate
    {
        public int Calculate(int Operand1, int Operand2, char Operation)
        {
            int result = 0; // have to set result variable as an int

            // switch statement to actually calculate 
            switch (Operation)
            {
                case '+':
                {
                    result = Add(Operand1, Operand2);
                    break;
                }

                case '-':
                {
                    result = Subtract(Operand1, Operand2);
                    break;
                }
                case '*':
                {
                    result = Multiply(Operand1, Operand2);
                    break;
                 }

                case '/':
                {
                    result = Divide(Operand1, Operand2);
                    break;
                }
                case '%':
                {
                    result = Modulus(Operand1, Operand2);
                    break;
                }
                
            }

            return result;
        }

        // Evaluations
        public int Add(int operandOne, int operandTwo)
        {
            return operandOne + operandTwo;
        }
        public int Subtract(int operandOne, int operandTwo)
        {
            return operandOne - operandTwo;
        }

        public int Multiply(int operandOne, int operandTwo)
        {
            return operandOne * operandTwo;
        }

        public int Divide(int operandOne, int operandTwo)
        {
            return operandOne / operandTwo;
        }

        public int Modulus(int operandOne, int operandTwo)
        {
            return operandOne % operandTwo;
        }
    }
}
