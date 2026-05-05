// Today we will do a mini project on extension methods and method overloading in C#.

PersonModel person = new PersonModel();

person.Fname = "What is your first name: ".ReqString();
person.Lname = "What is your Last Name: ".ReqString();
person.Age = "What is your Age: ".ReqInt();
person.NumberOfChildren = "How Many Children do you have: ".ReqInt();

Console.WriteLine(person.Fname);
Console.WriteLine(person.Lname);
Console.WriteLine(person.Age);
Console.WriteLine(person.NumberOfChildren);


//*** This are old method of doing,We have to do in morder ways
//Console.Write("What is your first name: ");
//person.Fname = Console.ReadLine();
//Console.Write("What is your Last Name: ");
//person.Lname = Console.ReadLine();
//Console.Write("What is your Age: ");
//person.Age = int.Parse(Console.ReadLine());
//Console.Write("How many children do you have: ");
//person.NumberOfChildren = int.Parse(Console.ReadLine());


Console.ReadLine();

public static class ConsoleHelperExtension {

    public static string ReqString(this string message) {
        string output = "";
        while (string.IsNullOrWhiteSpace(output)) {
            Console.Write(message);
            output = Console.ReadLine();
        }
        return output;
    }
    public static int ReqInt (this string message)
    {
        int output = 0;
        bool isvalid = false;
        while(isvalid == false)
        {
            Console.Write(message);
            isvalid=int.TryParse(Console.ReadLine(), out output);
        }
        return output;
    }
}


public class PersonModel
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public int Age { get; set; }
    public int NumberOfChildren { get; set; } 
}   