using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetFrameworkLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string prefix, string fname, string lname)
        {
            return $"Welcome {prefix} {fname} {lname} to our Demo Application! (from dotnetFrameworkLibrary)";
        }
        public string FarewellMessage(string prefix, string fname, string lname)
        {
            return $"Goodbye {prefix} {fname} {lname}, we hope to see you again soon! (from dotnetFrameworkLibrary)";
        }
    }
}
