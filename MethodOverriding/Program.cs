// Today we will learn about method overriding in C#. Method overriding is a feature of object-oriented programming that
// allows a derived class to provide a specific implementation of a method that is already defined in its base class.
// When a method in a derived class has the same name, return type, and parameters as a method in its base class,
// the derived class method overrides the base class method. 
// We already know about it , So today we wont be going much details

// We are well know with virtual,override,base keywords in C# and how they are used to implement method overriding.
// lets go a deep

PersonModel person = new PersonModel 
{
    FName = "Himel",
    LName = "Rahman",
    Email = "himel@email.com"
};
//Console.WriteLine(person);
// Console.WriteLine(person) automatically calls ToString() method on the object
// Every class in C# secretly inherits from a base class called 'object'
// object has a default ToString() that just returns the class name — "PersonModel"
// OUTPUT WITHOUT OVERRIDE: PersonModel

//Console.WriteLine(person);
// after overriding ToString() method Output will be: Himel Rahman (himel@email.com)














public class PersonModel
{
    public string FName { get; set; }
    public string LName { get; set; }  
    public string Email { get; set; }

    public override string ToString()
    {
        // return base.ToString(); instead of this we can return our own string representation by overriding the ToString() method 
        return $"{FName} {LName} ({Email})";
    }

    //public abstract void StartTime();
}

public class EmployeeModel : PersonModel
{
    public decimal HourlyRate { get; set; }

    public virtual decimal GetTotalIncome (int hoursWorked)
    {
        return HourlyRate * hoursWorked;
    }

}

public class CommisionEmployeeModel : EmployeeModel
{
    public decimal CommissionAmount { get; set; }

    public override decimal GetTotalIncome(int hoursWorked) // overriding the GetTotalIncome method as they also get commission in addition to their hourly rate, so we need to calculate their total income differently than a regular employee
    {
        return base.GetTotalIncome(hoursWorked) + CommissionAmount; 
    }


}