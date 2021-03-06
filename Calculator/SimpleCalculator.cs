﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleCalculator
    {
        // Comments
        public int AddInts(int a, int b)
        {
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int DivideInts(int a, int b)
        {
            if (a > 200)
            {
                throw new ArgumentOutOfRangeException("a");
            }

            return a / b;
        }
    }
}
