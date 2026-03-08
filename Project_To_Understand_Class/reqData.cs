using System;
using System.Collections.Generic;
using System.Text;

namespace Project;
    public static class reqData
    {
    public static (string,int) userData(int ctr) {
        Console.WriteLine($"You Are User Number : {ctr}");
        Console.Write("What is Your Name : ");
        string UName = Console.ReadLine();
        Console.Write("How Many Number Operation You Wanna Perform: ");
        int Uoperation = Convert.ToInt32(Console.ReadLine());
        return (UName, Uoperation);
    }
    public static (char,double,double) UserCalcData(string Uname) {
        Console.Write($"Hello {Uname}, What Type of Operation You Wanna Perform? (eg:+,-,*,/) : ");
        char operation = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"To Perform {operation} <:::> We Need Two Numbers");
        Console.Write("First Number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Second Number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        return (operation, num1, num2);
    }


    }
