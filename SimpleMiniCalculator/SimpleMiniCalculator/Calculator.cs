using System;
using System.Diagnostics;

namespace SimpleMiniCalculator
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y) 
        {
            return x - y; 
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return x / y;
        }
    }
}
