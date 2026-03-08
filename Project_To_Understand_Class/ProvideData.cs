using System;
using System.Collections.Generic;
using System.Text;

namespace Project;

public static class ProvideData
{
    public static void TopMsg()
    {
        Console.WriteLine("Welcome To Our Admin-User Based Calculator (To Understand Class Properly) ");
        Console.WriteLine("-------------------------------------------------------------------------- ");
        Console.WriteLine();
    }
    public static (string, int) adminMsg()
    {
        Console.WriteLine("Hello Respected Admin! Let's First Deals With You :@");
        Console.Write("What is Your Name: ");
        string name = Console.ReadLine();
        Console.Write($"Ok! {name}, How Many Number of User Will be Here Today: ");
        int totalUser = Convert.ToInt32(Console.ReadLine());
        return (name, totalUser);
    }
    public static void finalOutput(string Uname, char operation, double num1, double num2, double result)
    {
        Console.WriteLine($"The Result of {Uname}'s Operation {num1} {operation} {num2} is : {result}");
    }
    public static void EndMsg()
    {
        Console.WriteLine("Thank You For Using Our Calculator, See You Soon :)");
    }
    public static char adminEndMsg(string adminName)
    {
        Console.Write($"Thank You {adminName} For Using Me, Should We Close Now (Y/N) : ");
        char close = Convert.ToChar(Console.ReadLine());
        if (close == 'Y' || close == 'y')
            Console.WriteLine("Closing The Program, See You Soon :)");
        else
            Console.WriteLine("Ok! Let's Continue :)");
        Console.Clear();
        return close;
    }
}

