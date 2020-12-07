using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {

        private Calculator() { }

        private static Calculator calculator;

        public static Calculator TurnOn()
        {
            if (calculator == null) return new Calculator();
            return calculator;
        }

        public double Add(double addend1, double addend2)
        {
            return addend1 + addend2;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Multiply(double multiplier, double mulitplicanda)
        {
            return multiplier * mulitplicanda;
        }

        public double Divide(double divident, double divisor)
        {
            return divident / divisor;
        }
    }
}
