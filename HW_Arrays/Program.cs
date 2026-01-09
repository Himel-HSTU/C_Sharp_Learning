// Mini Project of Tim Corey C# Mastercourse - Arrays
// Task: Create a array of name from a single string of names separated by comma
// ask the user to input the order of name they want to see,check for validity and display the name

Console.Write("Please input a String with multiple names separated by ',' : ");
string? data = Console.ReadLine();
//Console.WriteLine(data);

string[] names = data.Split(',');
Console.WriteLine(names.Length);



//int n = Console.Read();
//Console.WriteLine(n); // Some Observations: We Avoid Earlier :( Console.Read() reads the next character as an integer, not the actual number. it reads the ASCII value of the character.
// thus in output if user inputs 3 it reads 51 as output
// To read the actual integer input we can use Console.ReadLine() and then convert it to integer using Convert.ToInt32() or int.Parse()
// int n = Convert.ToInt32(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());

bool chk = true;
while (chk) {
    Console.Write("Enter the Order of Input Names :");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(n);
    if (n > 0 && n <= names.Length)
    {
        Console.WriteLine($"The name at Position {n} is : {names[n - 1].Trim()}");
        chk = false;
    }
    else Console.WriteLine("Input Order is Invalid!!!\n");
}