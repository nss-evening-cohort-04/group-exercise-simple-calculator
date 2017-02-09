using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        public int Divide(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }

        public int Modulus(int firstNum, int secondNum)
        {
            return firstNum % secondNum;
        }
    }
}
