using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        public int Add(int valOne, int valTwo)
        {
            return valOne + valTwo;
        }

        public int Subtract(int valOne, int valTwo)
        {
            return valOne - valTwo;
        }

        public int Divide(int valOne, int valTwo)
        {
            return valOne / valTwo;
        }

        public int Multiply(int valOne, int valTwo)
        {
            return valOne * valTwo;
        }

        public int Modulus(int valOne, int valTwo)
        {
            return valOne % valTwo;
        }
    }
}
