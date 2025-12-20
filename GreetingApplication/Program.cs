//This is a Basic Greeting Application in C# by following Tim Corey C# MasterClass No.17-18

// Welcoming User
Console.WriteLine("Welcome to my Greeting Application!!");
Console.WriteLine("------------------------------------");
Console.WriteLine();
Console.WriteLine();
//Taking User Input n Outputting it Back
Console.Write("Please Enter Your First Name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Here's Your First Name: "+ firstName);
Console.WriteLine();
Console.Write("Please Enter Your Last Name: ");
string lastName=Console.ReadLine();
Console.WriteLine("Here's Your Last Name: "+lastName);
Console.WriteLine();
Console.WriteLine("Here's Your Full Name: "+firstName+" "+lastName);
Console.WriteLine();
Console.WriteLine("Thank You for Using My Greeting Application!!");
//Special Learning: Never Trust any User Input Without Validating It First.They can 
//Name like 42,69 or a full line or anything which may break your code.