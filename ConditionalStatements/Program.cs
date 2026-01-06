// ==========================================================
// 🔀 Conditional Statements in C#
// Topics: if, else if, else, switch
//
// Note:
// I already know conditional logic from C/C++
// (~2 years of Competitive Programming),
// so this file focuses mainly on C# syntax & behavior.
// ==========================================================



// ======================= if / else =========================
// if condition must be BOOLEAN in C#

bool is_check = false;

if (is_check)                     // takes only bool
    Console.WriteLine("Condition is true");
else
    Console.WriteLine("Condition is false");



// ======================= if / else if / else ===============
// Reading input and comparing strings

string? name = Console.ReadLine();

// (Assuming input is not null for now)

if (name.ToLower() == "himel")
{
    Console.WriteLine($"Welcome Back Mr. {name}");
}
else if (name.ToLower() == "max")
{
    Console.WriteLine($"Hey Mrs. {name}, hope Mr. Himel is fine!");
}
else
{
    Console.WriteLine($"Hello {name}, let's be friends :)");
}



// ======================= switch ============================
// switch is cleaner when comparing ONE variable
// against multiple fixed values

switch (name.ToLower())
{
    case "himel": // case "himel" or "max":
    case "max":
        Console.WriteLine($"Welcome Back, {name}!!!");
        break;

    case "holly":
        Console.WriteLine($"{name} !!!");
        break;

    default:
        Console.WriteLine("Hello, Random People!!!");
        break;
}



/*//................ Conditional Statements ................
//Today we will learn about conditional statements in C# ex. if, else if, else, and switch.
//as i know many things alraedy about conditional statements in programming,we will go through basic concepts quickly
//alrady worked with these statements in C,C++,almost 2 years in Competitive programming

//..................if, else, else if..................
bool is_check = false;
if (is_check) //this takes boolean value only
    Console.WriteLine("Condition is true");
else
    Console.WriteLine("Condition is false");

string? name= Console.ReadLine();
if (name.ToLower() == "himel")
{
    Console.WriteLine($"Welcome Back Mr.{name}");
}
else if(name.ToLower()=="max")
{
    Console.WriteLine($"Hey Mrs.{name},Hope Mr.Himel is Fine!!!");
}
else
{
    Console.WriteLine($"Hello,{name} Let's Be Friends :) !!!");
}
//................ Switch .............
switch (name.ToLower())
{
    case "himel" or "max":
        Console.WriteLine($"Welcome Back,{name}!!!");
        break;
    case "holly":
        Console.WriteLine($"{name} Shitt!!!");
        break;
    default:
        Console.WriteLine("Hello,Random People!!!");
        break; 
}
*/