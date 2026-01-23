// Today we will discuss about Dictionary in C#
// In simple words, Dictionary is similar to Map in C++
// We already know how to handle maps in C++
// Just a little syntax difference here
// Dictionary is a collection of key-value pairs
// Keys must be unique, values can be duplicate

//...................... Dictionary in C# ............................

Dictionary<string, int> ages = new(); // modern C# syntax
// Old declaration:
// Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

ages["Alice"] = 30;
ages["Bob"] = 25;
ages["Charlie"] = 35;
ages.Add("David", 18);

Console.WriteLine(ages["Bob"]);   // access value by key // output: 25
Console.WriteLine(ages.Count);    // total key-value pairs // output: 4

// There are multiple ways to initialize a Dictionary in C#

// empty dictionary
// Dictionary<string, int> dict1 = new ();

// with initial values
// Dictionary<string, int> dict2 = new ()
// {
//     { "Alice", 30 },
//     { "Bob", 25 }
// };

// using key-value assignment
// dict2["Charlie"] = 35;

// using Add method
// dict2.Add("David", 40);

// Now lets talk about the ways of iterating through a Dictionary

// Method 1: Using foreach loop (most common)

foreach (var it in ages)
{
    Console.WriteLine($"Name: {it.Key}, Age: {it.Value}");
}

// there are multiple in-built functions available in Dictionary class

// Check if a key exists
if (ages.ContainsKey("Alice"))
{
    Console.WriteLine("Alice is in the dictionary.");
}

// TryGetValue -> safe way to get value without exception
if (ages.TryGetValue("Charlie", out int charlieAge))
{
    // it tries to get the value for key "Charlie"
    // if exists, stores it in charlieAge variable
    Console.WriteLine($"Charlie's age is {charlieAge}.");
}

// Remove a key-value pair
ages.Remove("David");
Console.WriteLine($"After removal, total entries: {ages.Count}");

// Clear the dictionary (removes everything)
ages.Clear();
Console.WriteLine($"After clearing, total entries: {ages.Count}");


// Previously we skipped a part called Parse
// Parsing is converting string to other data types

string numberStr = "12345";
int number = int.Parse(numberStr); // converts string to int
Console.WriteLine($"Parsed number: {number}");

// You can also use TryParse to avoid exceptions
if (int.TryParse("67890", out int parsedNumber))
{
    Console.WriteLine($"Successfully parsed: {parsedNumber}");
}
else
{
    Console.WriteLine("Failed to parse the string.");
}


/*
// Today we will discuss about Dictionary in C#
// In simple words, Dictionary is similar to Map in C++
// We already know how to handle maps in C++
// Just a little syntax difference here
// Dictionary is a collection of key-value pairs
// Keys must be unique, values can be duplicate

//...................... Dictionary in C# ............................

Dictionary<string, int> ages = new(); // modern C# syntax
// Old declaration Dictionary<TKey, TValue> dict = new *Dictionary<TKey, TValue>*();

ages["Alice"] = 30;
ages["Bob"] = 25;
ages["Charlie"] = 35;
ages.Add("David", 18);

Console.WriteLine(ages["Bob"]); // access value by key // outputs 25

Console.WriteLine(ages.Count); // total key-value pairs // outputs 4    

// There are multiple ways to initialize a Dictionary in C#
// empty dictionary
// Dictionary<string, int> dict1 = new ();
// with initial values
// Dictionary<string, int> dict2 = new () { {"Alice", 30}, {"Bob", 25} };
// using Key and value pairs dict2["Charlie"] = 35;
// using add method like dict2.Add("David", 40);

//Now lets talk about the ways of iterating through a Dictionary

// Method 1: Using foreach loop

foreach (var it in ages)
{
    Console.WriteLine($"Name: {it.Key}, Age: {it.Value}");
}

// theres is multiple in built function available in Dictionary class
// Check if a key exists
if (ages.ContainsKey("Alice"))
{
    Console.WriteLine("Alice is in the dictionary.");
}
// try get value safely
if (ages.TryGetValue("Charlie", out int charlieAge)) // what it does is it tries to get the value for key "Charlie" and if it exists it stores it in charlieAge variable
{
    Console.WriteLine($"Charlie's age is {charlieAge}.");
}

// Remove a key-value pair
ages.Remove("David");
Console.WriteLine($"After removal, total entries: {ages.Count}");
// Clear the dictionary
ages.Clear();
Console.WriteLine($"After clearing, total entries: {ages.Count}");


// Previously we skip a part called Parse
// Parsing is converting string to other data types
string numberStr = "12345";
int number = int.Parse(numberStr); // converts string to int
Console.WriteLine($"Parsed number: {number}");
// You can also use TryParse to avoid exceptions
if (int.TryParse("67890", out int parsedNumber))
{
    Console.WriteLine($"Successfully parsed: {parsedNumber}");
}
else
{
    Console.WriteLine("Failed to parse the string.");
}
*/