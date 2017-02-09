using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalcMath
    {
        public static int Add(int valOne, int valTwo)
        {
            return valOne + valTwo;
        }

        public static int Subtract(int valOne, int valTwo)
        {
            return valOne - valTwo;
        }

        public static int Divide(int valOne, int valTwo)
        {
            return valOne / valTwo;
        }

        public static int Multiply(int valOne, int valTwo)
        {
            return valOne * valTwo;
        }

        public static int Modulus(int valOne, int valTwo)
        {
            return valOne % valTwo;
        }
    }
}
