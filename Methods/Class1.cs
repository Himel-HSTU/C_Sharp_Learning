using System;
using System.Collections.Generic;
using System.Text;

namespace Methods;

    public static class SampleClass
    {
        public static void SayHi()
        {
            Console.WriteLine("Hello Respected User!");
        }
        public static void SayBye()
        {
            Console.WriteLine("Goodbye Respected User!");
        }
        public static int addition(int a,int b)
        {
            return a + b;
        }
        public static int tri_addition(int a, int b)
        {
            int c = int.Parse(Console.ReadLine());
            return a + b + c;
        }
    }

