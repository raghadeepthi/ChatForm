using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public delegate int MathOperation(int a ,int b);
    public class Calculator
    {
        private MathOperation Operation;
        //Constructor...
        public Calculator(MathOperation op)
        {
            Operation = op;
        }
        //Method.. `                                                                                                                                                        
        public void CalculateAndPrint(int a, int b)
        {
            int res = Operation(a, b);
            Console.WriteLine(res);

        }

    }
}
