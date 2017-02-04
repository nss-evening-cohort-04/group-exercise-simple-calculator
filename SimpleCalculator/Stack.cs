using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Stack
    {
        public string LastQuery { get; set; }

        public int LastAnswer { get; set; }

        public string setLastQuery(string userQuestion)
        {
            LastQuery = userQuestion;
            return LastQuery;
        }

        public int setLastAnswer(int calculatorAnswer)
        {
            LastAnswer = calculatorAnswer;
            return LastAnswer;
        }


    }
}
