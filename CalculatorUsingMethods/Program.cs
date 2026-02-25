// In this program we will create a simple calculator that can perform basic arithmetic operations such as addition, subtraction, multiplication, and division. We will define methods for each operation and then call these methods from the Main method.
using CalculatorUsingMethods;

Console.Write("Hello,What is Your Name: ");
string name = Console.ReadLine();
if (name == "")
{
    Console.Write("Please Enter a Correct Name: ");
    name = Console.ReadLine();
}
Console.WriteLine($"Welcome {name},To Our Basic Calculator (Using Methods)");
bool wantMore = true;
while (wantMore)
{
    Console.Write("What Type of Operation You Wanna Perform (eg. +,-,*,/): ");
    string operation = Console.ReadLine();
    Console.WriteLine($"OK!!! So, You Wanna Perform {operation}, We Need Two Numbers!");
    Console.Write("Enter The First  Number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter The Second Number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"So The Numbers are: {num1} and {num2} ");
    // Now we will call the appropriate method based on the user's choice of operation
    if (operation == "+")
        operations.add(num1, num2);
    
    else if (operation == "-")
        operations.sub(num1, num2);
    
    else if (operation == "*")
        operations.multi(num1, num2);
    
    else if (operation == "/")
        operations.div(num1, num2);

    Console.Write("Wanna Do Another Operation? (Y/N) : ");

    string response= Console.ReadLine();

    if (response == "Y" || response == "y")
        wantMore = true;
    else if (response == "N" || response == "n")
        wantMore = false;
}
