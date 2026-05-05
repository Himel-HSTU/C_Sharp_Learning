// Today we will learn about method overloading and polymorphism in C#. 
// Method overloading allows you to define multiple methods with the same name but different parameters.
// Depending on what parameters we are passing to the method, the appropriate method will be called.
// *Polymorphism* is one of the four pillars of object-oriented programming.
// It is majorly two types: Compile-time polymorphism and Run-time polymorphism.
// Compile-time polymorphism is achieved through method overloading and operator overloading, 
// run-time polymorphism is achieved through method overriding.

// We Know about this concept from our C++ n OOP knowladge.

var person = new PersonModel("Himel","Rahman");
//person.GenerateEmail();// $"{Fname}.{Lname}@example.com" // Himel.Rahman@example.com
person.GenerateEmail("hawasoft.com", true); //$"{Fname.Substring(0, 3)}.{Lname}@{domain}" // Him.Rahman@hawasoft.com

Console.WriteLine(person.Email);

Console.ReadLine();     

public class PersonModel  
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Email { get; set; }

    public PersonModel()
    {
        
    }
    public PersonModel(string emailAddress)
    {
        Email = emailAddress;
    }
    public PersonModel(string firstName, string lastName)
    {
        Fname = firstName;
        Lname = lastName;
    }
    public PersonModel(string firstName, string lastName, string emailAddress)
    {
        Fname = firstName;
        Lname = lastName;
        Email = emailAddress;
    }
    //public PersonModel(string emailAddress,string firstName, string lastName) 
    // This will give error case it only sees (string,string,string) thus it overlap with the above constructor

    public void GenerateEmail()
    {
        Email = $"{Fname}.{Lname}@example.com";
    }
    public void GenerateEmail(string domain)
    {
        Email = $"{Fname}.{Lname}@{domain}";
    }
    public void GenerateEmail(bool firstInitialMethod)
    {
        if (firstInitialMethod == true)
            Email = $"{Fname.Substring(0,1)}.{Lname}@example.com";
        else Email = $"{Fname}.{Lname}@example.com";
    }
    public void GenerateEmail(string domain,bool firstInitialMethod)
    {
        if (firstInitialMethod == true)
            Email = $"{Fname.Substring(0, 3)}.{Lname}@{domain}";
        else Email = $"{Fname}.{Lname}@{domain}";
    }
    // We can also make the GenerateEmail following Dry by just simply calling one method to other method like below
    public void GenerateEmail(string domain, bool firstInitialMethod, bool isDry)
    {
        if (firstInitialMethod == true)
            GenerateEmail(domain);
        else GenerateEmail(domain);
    }
}
