using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class MathProblemStack
    {
       Stack<string> MathProblems = new Stack<string>();

       public void addNewMathProblem (string newMathProblem)
        {
            MathProblems.Push(newMathProblem);
        }

        public string getLastMathProblem ()
        {
            string returnedMathProblem = MathProblems.Peek().ToString();
            return returnedMathProblem;
        }
    }
}
