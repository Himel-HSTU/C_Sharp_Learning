using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemoLibrary
{
    public class MathCalculation
    {
        public double Calc(double x,double y, char c)
        {
            double output = 0;
            switch (c)
            {
                case '+':
                    output = x + y;
                    break;
                case '-':
                    output = x - y;
                    break;
                case '*':
                    output = x * y;
                    break;
                case '/':
                    if (y == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    output = x / y;
                    break;                
            }
            return output;
        }
    }
}
