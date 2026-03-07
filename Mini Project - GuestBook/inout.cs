using System;
using System.Collections.Generic;
using System.Text;

namespace GuestBook;

public static class inout
{
    public static void welcomeFunc()
    {
        Console.WriteLine("-- Hello,Our Respected Guest! ---");
        Console.WriteLine("---- Welcome to the GuestBook! -----");
        Console.WriteLine("------ Please Provide Us With Your Family Name and Number of Members Attened Today! -----");
        Console.WriteLine("### Add Details :");
    }
    public static void inFunc(List<string> names,List<int> members)
    {
        Console.Write("Please Enter The Family Name: ");
        string name =Console.ReadLine();
        if (name == "") {            
            Console.Write("Please Enter a Correct Family Name: ");
            name = Console.ReadLine();
        }
        Console.Write("Please Enter The Number of Family Members Attened Today: ");
        int num = Convert.ToInt32(Console.ReadLine());
        names.Add(name);
        members.Add(num);
    }
    public static void outFunc(List<string> names, List<int>members)
    {
        int total = 0;
        int count = 1;
        for (int i = 0; i < names.Count; i++) {
            Console.WriteLine($"{count}. Family Name: {names[i]} -> Members: {members[i]}");
            total = total + members[i];
            count++;
        }
        Console.WriteLine($"The Number of Total Members Attened Today is {total}.");
    }
}
