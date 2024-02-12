using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCalculator
{
    public static class Calculate
    {
        public static double Calc(double n1, double n2, string MathOperator)
        {

            switch (MathOperator)
            {
                case "*": 
                    return n1 * n2;

                case "/":
                    return n1 / n2; 

                case "+":
                    return n1 + n2; 

                case "-":
                    return n1 - n2; 

                default:
                    return 0;
            }
        }
    }
}
