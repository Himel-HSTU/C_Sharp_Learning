using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples;
    public static class inputoutput
    {
       public static (string,string,int) operation() {
        Console.Write("Please Write Your First Name: ");
        string fname = Console.ReadLine();
        Console.Write("Please Write Your Last Name: ");
        string lName = Console.ReadLine();
        Console.Write("Please Write Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        return (fname, lName, age);  
    }
    }
