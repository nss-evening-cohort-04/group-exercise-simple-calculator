using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class StackStorage
    {
        public Stack<string> Stack { get; set; }
       
        public StackStorage()
        {
            Stack = new Stack<string>();
        }

        public void addMathToStack(string addedMathProblem)
        {
            Stack.Push(addedMathProblem);
        }

        public string getLastProblem()
        {
            string getLast = Stack.Peek().ToString();
            return getLast;
        }
    }
}
