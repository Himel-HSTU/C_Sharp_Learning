// This is a mini project from Tim Corey C# MasterCourse Video 64-67
// The main motivation behind this project is to create a simple guest book application where users can enter their name and number of family members
// in the end we have to output the list of guests and their family members. This project will help us to understand the basics of C# programming and also how to work with dictoinary lists and classes.
using GuestBook;
inout.welcomeFunc();
bool more = true;
List<string> names = new();
List<int> members = new();
while (more)
{
    inout.inFunc(names, members);
    Console.Write("Add Another Details (eg: Y/N) : ");
    string response = Console.ReadLine();
    if (response == "Y" || response == "y")
        more = true;
    else if (response == "N" || response == "n")
        more = false;
    else more = false;
}
inout.outFunc(names, members);

