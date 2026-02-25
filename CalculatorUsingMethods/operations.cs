using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUsingMethods;

    public static class operations
    {
    public static void add(double n1,double n2)
    {
        Console.WriteLine($"The Result of {n1}+{n2} is {n1+n2}");
    }
    public static void sub(double n1, double n2)
    {
        Console.WriteLine($"The Result of {n1}-{n2} is {n1 - n2}");
    }
    public static void multi (double n1, double n2)
    {
        Console.WriteLine($"The Results of {n1}*{n2} is {n1 * n2}");
    }
    public static void div(double n1,double n2)  {
        if (n2 == 0)
            Console.WriteLine("Denominator can't be 0.... Dustuu:(");

        else Console.WriteLine($"The Result of {n1}/{n2} is {n1 / n2}");
    }
}

