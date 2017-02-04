using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine($"[{counter}]");
            
            var command = Console.ReadLine();

            var responseTest = Expression.getMathExpression(command);
            Console.WriteLine(responseTest[2]);

            Console.ReadLine();
        }
    }
}
