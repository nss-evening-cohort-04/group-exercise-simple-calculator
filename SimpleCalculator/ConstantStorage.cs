using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class ConstantStorage
    {
        Dictionary<string, int> addConstantVariable = new Dictionary<string, int>();

        public ConstantStorage()
        {
            addConstantVariable.Add("x", 446);
            addConstantVariable.Add("s", 1233);
            addConstantVariable.Add("z", 94);
        }

    }
}
