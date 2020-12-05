using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operation
    {
        public static double Add(double addend1, double addend2)
        {
            return addend1 + addend2;
        }

        public static double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public static double Multiply(double multiplier, double mulitplicanda)
        {
            return multiplier * mulitplicanda;
        }

        public static double Divide(double divident, double divisor)
        {
            return divident / divisor;
        }
    }
}
