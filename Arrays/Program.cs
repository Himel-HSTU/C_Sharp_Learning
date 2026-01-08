// Today we will learn about arrays in C#.
// again we have previously good knowledge about arrays from C, C++...

//....................... Arrays in C# ...........................
// An array is a collection of items stored at contiguous memory locations.
// The idea is to store multiple items of the same type together.

int[] ar = new int[5]; // declaration and instantiation of array
                       // default output : 0 0 0 0 0

ar[0] = 10; // initialization
ar[1] = 20;
ar[2] = 30;
ar[3] = 40;
ar[4] = 50;

// accessing array elements using for loop
for (int i = 0; i < ar.Length; i++)
{
    Console.Write(ar[i] + " ");
}

Console.WriteLine();

// 1. Arrays are FIXED size (cannot grow or shrink)

// 2. Arrays are reference types
int[] a = { 1, 2, 3 };
int[] b = a;   // b points to same array

b[0] = 99;
// a[0] is now also 99

// 3. IndexOutOfRangeException is VERY common
// accessing invalid index will crash the program

// 4. foreach is safest for reading
foreach (int x in a)
{
    Console.WriteLine(x);
}

// 5. Arrays have built-in helper methods
// Array.Sort(arr);
// Array.Reverse(arr);
// Array.IndexOf(arr, value);


// we can declare, instantiate and initialize an array in many ways

// 1️. declaration only (no memory allocated yet)
// int[] arr;

// 2️. declaration + instantiation (default values = 0 for int)
// int[] arr = new int[5];

// 3️. declaration + instantiation + initialization (explicit size)
// int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };

// 4️. declaration + instantiation + initialization (size inferred)
// int[] arr2 = { 1, 2, 3, 4, 5 };

// 5️. using 'new' keyword with inferred size
// int[] arr3 = new[] { 1, 2, 3, 4, 5 };

// 6️. empty array (size = 0, very common in safe coding)
// int[] arr4 = Array.Empty<int>();

// 7️. initialize with partial values (rest will be default = 0)
// int[] arr5 = new int[5] { 1, 2 };

// 8️. multi-line initialization (better readability)
// int[] arr6 = new int[]
// {
//     1,
//     2,
//     3,
//     4,
//     5
// };

// 9️. array of reference types (string example)
// string[] names = { "Alice", "Bob", "Charlie" };

// Don't worry about 10,11 for now, we will cover them in detail later.

// 🔟 jagged array (array of arrays)
// int[][] jagged = new int[2][];
// jagged[0] = new int[] { 1, 2, 3 };
// jagged[1] = new int[] { 4, 5 };

// 1️1. multi-dimensional array (matrix style)
// int[,] matrix = new int[2, 3]
// {
//     { 1, 2, 3 },
//     { 4, 5, 6 }
// };

// we can construct a string array even from a plain string
// consisting of text separated by commas or other identifiers

string data = " Apple, Bannana,   Mango,Orange";

string[] fruits = data.Split(','); // Split method of string class
                                   // data string is split at each comma

for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine(fruits[i]);   // output will contain extra spaces
                                    // because Split does not trim
}

Console.WriteLine();

// removing extra spaces using Trim()
for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine(fruits[i].Trim()); // Trim removes leading & trailing spaces
}




/*// Today we will learn about arrays in C#.
// again we have previously good knowledge about arrays from C,C++...
//....................... Arrays in C# ...........................
// An array is a collection of items stored at contiguous memory locations.
// The idea is to store multiple items of the same type together.

int[] ar = new int[5]; //declaration and instantiation of array // output : 0 0 0 0 0
ar[0] = 10; //initialization
ar[1] = 20;
ar[2] = 30;
ar[3] = 40;
ar[4] = 50;
//accessing array elements using for loop
    for (int i = 0; i < ar.Length; i++)
{
    Console.Write(ar[i] + " ");
}
Console.WriteLine();
// we can declare, instantiate and initialize an array in many ways

// 1️.declaration only (no memory allocated yet)
// int[] arr;

// 2️. declaration + instantiation (default values = 0 for int)
// int[] arr = new int[5];

// 3️. declaration + instantiation + initialization (explicit size)
// int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };

// 4️. declaration + instantiation + initialization (size inferred)
// int[] arr2 = { 1, 2, 3, 4, 5 };

// 5️. using 'new' keyword with inferred size
// int[] arr3 = new[] { 1, 2, 3, 4, 5 };

// 6️. empty array (size = 0, very common in safe coding)
// int[] arr4 = Array.Empty<int>();

// 7️. initialize with partial values (rest will be default = 0)
// int[] arr5 = new int[5] { 1, 2 };

// 8️. multi-line initialization (better readability)
// int[] arr6 = new int[]
// {
//     1,
//     2,
//     3,
//     4,
//     5
// };

// 9️. array of reference types (string example)
// string[] names = { "Alice", "Bob", "Charlie" };

// Don't worry about 10,11 for now, we will cover them in detail later.
// 🔟 jagged array (array of arrays)
// int[][] jagged = new int[2][];
// jagged[0] = new int[] { 1, 2, 3 };
// jagged[1] = new int[] { 4, 5 };

// 1️1 multi-dimensional array (matrix style)
// int[,] matrix = new int[2, 3]
// {
//     { 1, 2, 3 },
//     { 4, 5, 6 }
// };
// we can construct a string array even from just a plain string consist of text separated by commas or other identifier characters
string data = " Apple, Bannana,   Mango,Orange";
string[] fruits = data.Split(','); // Split method of string class
                                   // Data string is split at each comma and stored in fruits array
for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine(fruits[i]); // output will contain extra spaces as it just split the string with comma
                                  // thus many blank spaces are there before n after some fruit names
}

for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine(fruits[i].Trim()) ; // Trim method removes leading and trailing spaces
}
*/