﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Runner
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 8;
            Console.WriteLine("Результат сложения {0} и {1}: {2}", a, b, Operation.Add(a, b));
            Console.WriteLine("Результат вычитания {0} и {1}: {2}", a, b, Operation.Subtract(a, b));
            Console.WriteLine("Результат умножения {0} и {1}: {2}", a, b, Operation.Multiply(a, b));
            Console.WriteLine("Результат деления {0} и {1}: {2}", a, b, Operation.Divide(a, b));

            Console.ReadKey();
        }
    }
}
