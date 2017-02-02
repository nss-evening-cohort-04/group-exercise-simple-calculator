using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        //string pattern = ;
       public string input = "2+2";

        Match m = Regex.Match(@"2+2", @" ^ (?<number1>\d+)\s*(?<operator>[+\/\-%*]+)\s*(?<number2>\d+)\s*$");
        
    }
}
