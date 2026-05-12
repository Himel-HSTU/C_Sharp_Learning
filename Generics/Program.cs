// Today we will explore the concept of generics in C#. Generics allow you to define classes, methods, and data structures with a placeholder for the type of data they store or use. This enables you to create reusable and type-safe code.





string s = 1234.ToString();
Console.WriteLine(s);

//List<string> Slist = new List<string>(); //this only holds strings types 
//List<int> Ilist = new List<int>(); //this only holds int types
//List<double> Dlist = new List<double>(); //this only holds double types
//List<bool> Blist = new List<bool>(); //this only holds bool types

// What if we want to create a list that can hold any type of data? This is where generics come in .
// We can define a generic list that can hold any type of data by using the List<T> class, where T is a placeholder for the type of data.

//Console.WriteLine(FizzBuzz("tests")); // Output: Buzz! 
//Console.WriteLine(FizzBuzz(123));    // Output: Fizz!
//Console.WriteLine(FizzBuzz(new PersonModel { Fname="Himel",Lname="Rahman"}));// Output: Dhurrrr:)

GenericHelper<PersonModel> personHelper = new GenericHelper<PersonModel>();
personHelper.CheckItemAdd(new PersonModel { Fname = "Himel", Lname = "Rahman", HasError = true });
foreach (var item in personHelper.RejectedItems)
{
    Console.WriteLine($"{item.Fname} {item.Lname} has an error: {item.HasError}");
}



Console.ReadLine();

string FizzBuzz<T>(T item) // We can use A,B,C anything in place of T but T is the most common convention used in generics
{
    int itemLength = item.ToString().Length;
    string Output = "";
    //string Output = itemLength % 3 == 0 && itemLength % 5 == 0 ? "FizzBuzz!" 
    //                : itemLength % 3 == 0 ? "Fizz!" :
    //                  itemLength % 5 == 0 ? "Buzz!" :
    //                  itemLength.ToString();

    if (itemLength % 3 == 0)
    {
        Output += "Fizz!";
    }
    else if (itemLength % 5 == 0)
    {
        Output += "Buzz!";
    }
    else if (itemLength % 3 == 0 && itemLength % 5 == 0)
    {
        Output += "FizzBuzz!";
    }
    else Output += "Dhurrrr:)";
    return Output;
}

public class GenericHelper<T> where T : IErrorCheck, new( )
{
    public List<T> Items { get; set; } = new List<T>();
    public List<T> RejectedItems { get; set; } = new List<T>();

    public void CheckItemAdd(T item)
    {
        if (item.HasError == false)
        {
            Items.Add(item);
        }
        else RejectedItems.Add(item);
    }
}

public interface IErrorCheck
{
    bool HasError { get; set; }

}

public class CarModel : IErrorCheck
{
    public string  Manufacturer { get; set; }
    public int YearManufactured { get; set; }
    public bool HasError { get ; set ; }
}
public class PersonModel : IErrorCheck
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public bool HasError { get ; set; }

}