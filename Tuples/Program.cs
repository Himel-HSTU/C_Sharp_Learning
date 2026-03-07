// In this program we will explore the concept of tuples in C#.
// A tuple is a data structure that can hold multiple values of different types.
// It is a convenient way to group related data together without having to define a separate class or struct.
// We will create a simple program that demonstrates how to use tuples to store and manipulate data.
//The main conceptoftupleis we can bind multiple valueirrespecvtive of their types in a single variable.
//We can access these values using their position or by using named elements. Let's see how we can use tuples in C#.

using Tuples;                         
(string fname,string lname,int  age) info = inputoutput.operation();
Console.WriteLine($"Your Full Name is {info.fname} {info.lname}.");
Console.WriteLine($"Your Age is {info.age}.");

/*
 (string,string,int) info =inputoutput.operation();
/ var info =inputoutput.operation();
Console.WriteLine($"Your Full Name is {info.Item1} {info.Item2} ");
Console.WriteLine($"Your Age is {info.Item3} ");*/