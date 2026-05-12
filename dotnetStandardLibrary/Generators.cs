using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetStandardLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string prefix, string fname, string lname)
        {
            return $"Welcome {prefix} {fname} {lname} to our Demo Application! (from dotnetStandardLibrary)";
        }
        public string FarewellMessage(string prefix, string fname, string lname)
        {
            return $"Goodbye {prefix} {fname} {lname}, we hope to see you again soon! (from dotnetStandardLibrary)";
        }
    }
}
