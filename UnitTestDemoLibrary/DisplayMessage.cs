using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemoLibrary
{
    public class DisplayMessage
    {
        public string Greeting(string Fname,int HourOfTheDay)
        {
            string output = "";
            if (HourOfTheDay < 12)
            {
                output = $"Good Morning, {Fname}!";
            }
            else if (HourOfTheDay < 18)
            {
                output = $"Good Afternoon, {Fname}!";
            } 
            else
            {
                output = $"Good Evening, {Fname}!";
            }
            return output; 
        }
    }
}
