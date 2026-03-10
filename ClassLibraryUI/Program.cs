// Today,We will learn about class library in C#. A class library is a collection of classes, interfaces,
// and other types that can be used by other applications.
// It allows you to create reusable code that can be shared across multiple projects.
// For example for a project we make a class library that perform a task
// we are working on another project that also needs to perform the same task, instead of writing the code again 
// we can simply reference the class library and use the code from there. 
// Also the class library generate a .dll file that can be used by other applications.
// A Class library cannot be executed on its own, it is meant to be used by other applications.
// Also we have to add a reference to the class library in the project that we want to use it in,
// and then we can use the classes and methods defined in the class library.
using ClassLibraryModelLibrary.Models;

PersonModel person = new PersonModel();
person.fname = "John";
person.lname = "Doe";
Console.WriteLine($"{person.fname} {person.lname}");