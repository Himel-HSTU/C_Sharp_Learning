string firstname = string.Empty;
string lastname= string.Empty;

firstname = "Himel";
lastname = "Rahman";

Console.WriteLine(firstname +" "+ lastname);

///string interpolation
Console.WriteLine($"Full Name: {firstname} {lastname}");

// There are some special charecter in file path like \n,\t etc. which will not be treated as normal charecter.
//thus we have to use escape charcter \\ to represent single \ in file path.
// or we can use @ before string to treat the string as string literal.

string filepath = string.Empty;

filepath = "C:\\pc\\folder"; //Output: C:\pc\folder
Console.WriteLine(filepath);
filepath = @"C:\pc\folder"; //Output: C:\pc\folder
Console.WriteLine(filepath);

///aslo we can use both $ and @ together,the order does not matter.

string demo= $@"The file of {firstname} {lastname} is located at C:\pc\folder";
Console.WriteLine(demo);