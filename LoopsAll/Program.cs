//..........loops-all-start...........
//we will demonstrate different types of loops in C# ex. for, while, do-while, and foreach.
//We know all of this earlier from c,cpp .. Almost everything in C# is similar to C, C++
// So will go through quickly with examples


// .................. Do While Loop ..................

int ctr = 0;

do
{
    Console.WriteLine($"Number is {ctr}!");
    ctr++;
}
while (ctr < 10);

// few points about do-while loop : it must run at least once even if the condition is false initially
// first it will execute the block of code then check the condition



//................. While Loop .......................

int ctr2 = 0;

while (ctr2 < 10)
{
    Console.WriteLine($"Number is {ctr2}!!!");
    ctr2++;
}

// few points about while loop : it may not run at all if the condition is false initially
// first it will check the condition then execute the block of code



//................. For Loop ..........................

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Number is {i}!!!!!!!");
}

// few points about for loop : it is used only when the number of iterations is known
// it has three parts : initialization, condition, increment/decrement
// first it will initialize the variable, then check the condition, then execute the block of code, then increment/decrement the variable
// it will repeat this process until the condition is false



//................. Foreach Loop .......

string[] names = { "Alice", "Bob", "Charlie", "David" };

foreach (string s in names)
{
    Console.WriteLine(s);
}

// it is used to iterate over a collection or array without using an index variable
// we don't need to worry about the initialization, condition, increment/decrement or total number of iterations
// it will automatically iterate over each element in the collection or array
// perform the block of code for each element
// few points about foreach loop : it is read-only, we cannot modify the collection or array while iterating over it
// it is simpler and less error-prone than other loops when iterating over collections or arrays



/*
/..........loops-all-start...........
//we will demonstrate different types of loops in C# ex. for, while, do-while, and foreach.
//We know all of this earlier from c,cpp .. Almost everything in C# is similar to C, C++
// So will go through quickly with examples
// .................. Do While Loop ..................

int ctr = 0;
do
{
    Console.WriteLine($"Number is {ctr}!");
    ctr++;  
}
while (ctr<10);
// few points about do-while loop : it must run at least once even if the condition is false initially
//first it will execute the block of code then check the condition

//................. While Loop .......................
int ctr2 = 0;
while (ctr2 < 10)
{
    Console.WriteLine($"Number is {ctr2}!!!");
    ctr2++;
}
// few points about while loop : it may not run at all if the condition is false initially
// first it will check the condition then execute the block of code

//................. For Loop ..........................
for (int i =0; i<10; i++)
{
    Console.WriteLine($"Number is {i}!!!!!!!");
}
// few points about for loop : it is used only when the number of iterations is known
// it has three parts : initialization, condition, increment/decrement
// first it will initialize the variable, then check the condition, then execute the block of code, then increment/decrement the variable
// it will repeat this process until the condition is false

//................. Foreach Loop .......

string[] names = { "Alice", "Bob", "Charlie", "David" };
foreach (string s in names)
{
    Console.WriteLine(s);
}
// it is used to iterate over a collection or array without using an index variable
// we don't need to worry about the initialization, condition, increment/decrement or total number of iterations
// it will automatically iterate over each element in the collection or array
// perform the block of code for each element
// few points about foreach loop : it is read-only, we cannot modify the collection or array while iterating over it
// it is simpler and less error-prone than other loops when iterating over collections or arrays
*/