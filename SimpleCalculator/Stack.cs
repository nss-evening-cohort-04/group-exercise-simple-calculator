using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public string LastQuery { get; set; }
        public int LastAnswer { get; set; }

        public Stack()
        {
            LastQuery = "No Previous Queries.";
            LastAnswer = 0;
        }
    }
}
