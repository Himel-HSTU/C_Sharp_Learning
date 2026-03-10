using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesType
{
    internal class PersonModel
    {
        public string FirstName { get; set; } //This is an auto-implemented property.
                                              // When we don't need much control over the property,
        public string LastName {  get; set; }
        public string NickName { private get; set; }

        //public string FirstName { private get; set; }// the get is private, so we can only set the value of the property, but we can't get it directly from outside the class
        //public string LastName { get; private set; }// the set is private, so we can only get the value of the property, but we can't set it directly from outside the clas
        private int _age;
        public int age
        {
            get { return _age; }
            set {
                if (value < 0 || value > 100)  // This is a more broad implementation of the property,
                    throw new ArgumentOutOfRangeException(); // Where we are controling what to take as input
                else _age = value;
            }
        }

        private string _phonenumber;

        public string PhoneNumber
        {
            get { //In this way we are restricting the get of the property, and we are allowing a visible portion 
                string temp = "*******" + _phonenumber.Substring(_phonenumber.Length - 4); // This is a more complex implementation of the property,
                return temp; 
            }
            set { _phonenumber = value; }
        }

        private string _fullname;

        public string  FullName
        {
            get { return FirstName+" "+LastName+" "+"("+NickName+")"; }
            private set { _fullname = value; }
        }
       
        // Lets add another thing that is constructors, we can have constructors in our class to initialize the properties when we create an object of the class.
        //It create at the time of object creation and it is autometicaly get perameters and assing value of each property
        // When we dont create any constructor in our class, C# provides a default constructor that takes no parameters
        // and does nothing. But when we create a constructor with parameters,
        // the default constructor is no longer available, and we need to create it explicitly if we want to use it
        public PersonModel(string fn,string ln,string nm,int ag,string phnum) { 
            FirstName = fn;
            LastName = ln; 
            NickName = nm;
            age = ag;
            _phonenumber = phnum;
            Console.WriteLine("Manual Constructor Called");
        }
        public PersonModel() {
            Console.WriteLine("Default Constructor Called");
        } // This is a default constructor, it takes no parameters and does nothing.
    }
}
