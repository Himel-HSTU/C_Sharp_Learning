// Today we will discuss about Lists in C#
// In simple words, Lists are the Vectors of C++ in C#
// We already know how to handle vectors in C++
// Just a little syntax difference here
// Lists are dynamic in nature, i.e. we can add or remove elements at runtime
// No need to define size at the time of declaration

//...................... Lists in C# ............................

// List<int> numbers = new List<int>();
List<int> numbers = new();   // modern C# syntax

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);

Console.WriteLine(numbers.Count); // total elements

// There are multiple ways to initialize a List in C#

// empty list
// List<int> list1 = new List<int>();

// with initial values
// List<int> list2 = new List<int> { 1, 2, 3, 4 };

// from an array
// int[] arr = { 5, 6, 7 };
// List<int> list3 = new List<int>(arr);

// with capacity (performance optimization)
// List<int> list4 = new List<int>(100);

List<int> nums = new List<int>();

nums.Add(10);   // add single element
nums.Add(20);

nums.AddRange(new int[] { 30, 40, 50 }); // add multiple

Console.WriteLine(nums[0]);    // index access
Console.WriteLine(nums.Count); // total elements

// for loop
for (int i = 0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}

// foreach (most common)
foreach (int x in nums)
{
    Console.WriteLine(x);
}

// removing elements
nums.Remove(20);       // removes first occurrence → 10,30,40,50
nums.RemoveAt(0);      // removes by index → 30,40,50
nums.RemoveRange(1, 2);// remove 2 items from index 1 → 30

Console.WriteLine(nums.Count); // 1

nums.Clear();           // remove all
Console.WriteLine(nums.Count); // 0

nums.AddRange(new int[] { 10, 20, 30, 40, 50 });

// searching
bool exists = nums.Contains(30); // true if found
Console.WriteLine(exists);

int index = nums.IndexOf(40);    // index of first occurrence (-1 if not found)
Console.WriteLine(index);

// inserting
nums.Insert(1, 99); // 10,99,20,30,40,50 isert 99 at index 1
nums.InsertRange(2, new int[] { 7, 8, 9 }); // insert multiple at index 2
// 10,99,7,8,9,20,30,40,50

// sorting
nums.Sort();     // ascending → 7,8,9,10,20,30,40,50,99
nums.Reverse();  // reverse → 99,50,40,30,20,10,9,8,7

// List → Array
int[] array = nums.ToArray(); // we will get an array of integers with same elements as in nums list
Console.WriteLine(array.Length); // 9

// Array → List
List<int> newList = array.ToList();  // we will get a list of integers with same elements as in array
Console.WriteLine(newList.Count); // 9





/*
// Today We will discuss about Lists in C#
// In Sample Word,Lists is the Vectors of C++ in C#
// We know how to handle Vectors in Cpp..Just a little different syntax here
// Lists is dynamic in nature i.e we can add or remove elements at runtime
// No need to define size at the time of declaration

//......................Lists in C#..........................

//List<int> numbers = new List<int>();
List<int> numbers = new ();
numbers.Add(1);
numbers.Add(2); 
numbers.Add(3); 
numbers.Add(4);
Console.WriteLine(numbers.Count);

// There are multiple ways to initialize a List in C#
// empty list
// List<int> list1 = new List<int>();

// with initial values
// List<int> list2 = new List<int> { 1, 2, 3, 4 };

// from an array
// int[] arr = { 5, 6, 7 };
// List<int> list3 = new List<int>(arr);

// with size (performance optimization)
// List<int> list4 = new List<int>(100);

List<int> nums = new List<int>();

nums.Add(10);              // add single element
nums.Add(20);

nums.AddRange(new int[] { 30, 40, 50 }); // add multiple
Console.WriteLine(nums[0]);    // index access
Console.WriteLine(nums.Count); // total elements

// for loop
for (int i = 0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}

// foreach (most common)
foreach (int x in nums)
{
    Console.WriteLine(x);
}

nums.Remove(20);   // removes first occurrence List is : 10,30,40,50
nums.RemoveAt(0);   // removes by index List is : 30,40,50
nums.RemoveRange(1, 2); // remove multiple from index 1, count 2 List is : 30
Console.WriteLine(nums.Count);// 1
nums.Clear();       // remove all
Console.WriteLine(nums.Count);// 0

nums.AddRange(new int[] {10, 20, 30, 40, 50 }); // add multiple

bool exists = nums.Contains(30); // true if found // false if not found
Console.WriteLine(exists);

int index = nums.IndexOf(40);  // -1 if not found // index of first occurrence
Console.WriteLine(index);

nums.Insert(1, 99); // insert 99 at index 1 list is : 10,99,20,30,40,50
nums.InsertRange(2, new int[] { 7, 8, 9 }); // insert multiple at index 2 list is : 10,99,7,8,9,20,30,40,50

nums.Sort();     // ascending // output will be : 7,8,9,10,20,30,40,50,99
nums.Reverse();  // reverse order // output will be : 99,50,40,30,20,10,9,8,7

// List → Array
int[] array = nums.ToArray(); // we wil get an array of integers with same elements as in nums list
Console.WriteLine(array.Length); // prints length of array is 9

// Array → List
List<int> newList = array.ToList(); // we will get a list of integers with same elements as in array
Console.WriteLine(newList.Count); // prints count of newList is 9
*/






