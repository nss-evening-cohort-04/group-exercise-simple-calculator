using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("[" + counter + "]");
            string userMathProblem = Console.ReadLine();
            Expression userExpression = new Expression();
            userExpression.verifyUserMathProblem(userMathProblem);
            Console.WriteLine(userExpression.mathFactorA);
            Console.WriteLine(userExpression.mathOperator);
            Console.WriteLine(userExpression.mathFactorB);
            Console.ReadLine();
        }
    }
}
