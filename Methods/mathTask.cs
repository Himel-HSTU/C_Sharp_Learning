using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public static class mathTask
    {
        public static void AllAddition(double[] values)
        {
            double sum = 0;
            foreach ( double val in values)
            {
                sum += val;
            }
            Console.WriteLine($"The Sum of all Numbers is : {sum}");
        }
    }
}
