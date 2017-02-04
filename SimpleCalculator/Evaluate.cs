using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public int Add(int First, int Second)
        {
            return First + Second;
        }
        public int Subtract(int First, int Second)
        {
            return First - Second;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Modulus(int a, int b)
        {
            return a % b;
        }
    }
}
