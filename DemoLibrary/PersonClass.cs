using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    // Other two are protected internal and private protected. 
    public class DataAccess
    {
        internal string GetConnectionString() // Internal : anything within the same assembly can access this method. It cannot be accessed by outside or other assemblies.
        {                                     // Even if derived but other assembly cannot access this method. It is only accessible within the same assembly.
            return "SensetiveData";
        }
    }
    public class Person
    {
        //private string formerLastName=""; // Private only works within the class itself. It cannot be accessed by derived classes or other classes in the same assembly.
        protected string formerLastName = ""; // Protected works within the class itself and derived classes. It cannot be accessed by other classes in the same assembly.
        public string FirstName { get; set; }
        public string LastName { get; private set; }
        private string _ssn;

        public string SSN
        {
            get { return $"******{_ssn.Substring(_ssn.Length - 4)}"; }
            set { _ssn = value; }
        }
        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName} from PersonClass!");
        }

        public string Getoutput() {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.GetConnectionString();
        }
    }
    public class Employee : Person
    {
        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName} from EmployeeClass!");
        }
        public string GetFormerLastName()
        {
            // return formerLastName; // the employe class cannot access the formerLastName variable because it is private to the Person class
            return "";
        }
    }
    
}
