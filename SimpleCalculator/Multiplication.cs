﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Multiplication
    {
        public int Multiply(int GetA, int GetB)
        {
            var MultiplyAnswer = GetA * GetB;
            return MultiplyAnswer;
        }

        public int PrintNumber(int multiplyAnswer)
        {
            return multiplyAnswer;
        }


    }
}
