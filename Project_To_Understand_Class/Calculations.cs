using System;
using System.Collections.Generic;
using System.Text;

namespace Project;
    public static class Calculations
    {
        public static double calcChker(char operation,double num1,double num2)
    {
        double result = 0; 

        if (operation == '+')
           result = add(num1, num2);

        else if (operation == '-')
           result = sub(num1, num2);

        else if (operation == '*')
           result = multi(num1, num2);

        else if (operation == '/')
            result = div(num1, num2);
        return result;
    }
        
        private static double add(double n1,double n2) {  return n1 + n2; }
        private static double sub(double n1, double n2) { return n1 - n2; }
        private static double multi(double n1, double n2) { return n1 * n2; }
        private static double div(double n1, double n2)
    {
        if (n2 == 0 && n1 != 0)
        {
            Console.WriteLine("Denominator can't be 0.... Dustuu:(");
            return 69;
        }
        else return n1 / n2;
    }
    }

