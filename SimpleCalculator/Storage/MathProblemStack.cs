using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class MathProblemStack
    {
        public Stack<string> Stack { get; set; }

        public MathProblemStack()
        {
            this.Stack = new Stack<string>();
        }

        //public MathProblemStack(Stack<string> stack)
        //{
        //    this.Stack = stack;
        //}

       //Stack<string> MathProblems = new Stack<string>();

       public void addNewMathProblem (string newMathProblem)
        {
            Stack.Push(newMathProblem);
        }

        public string getLastMathProblem ()
        {
            string returnedMathProblem = Stack.Peek().ToString();
            return returnedMathProblem;
        }
    }
}
