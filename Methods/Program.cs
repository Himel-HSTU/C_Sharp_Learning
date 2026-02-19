// Today we will discuss about Methods in C#
// In simple words, Methods are similar to Functions in C++
// We already know how to handle functions in C++
// Just a little syntax difference here
// Methods are used to group a set of statements together to perform a specific task
// They help in code reusability and better organization
// ...................... Methods in C# ............................

//Methods.sampleClass.SayHi(); // This line of code is calling the SayHi method from the sampleClass in the Methods namespace.

//using Methods; // This line is using the Methods namespace, which allows us to access the classes and methods defined in that namespace without needing to fully qualify them.
//    sampleClass.SayHi();

//using static Methods.sampleClass;
// This line is using a static import to directly access the SayHi method from the sampleClass without needing to specify the class name.
//SayHi(); // This line is calling the SayHi method directly, which will print "Hello Respected User!" to the console.
//but everything has a longer,shorter and tinier version, it is recommended not to use tinier version as it can lead to confusion and make the code less readable, especially for those who are new to programming or are not familiar with the specific methods being used. It is generally better to use the full method name to maintain clarity and improve code readability.

//The best way to use methods is:

using Methods;

SampleClass.SayHi();
SampleClass.SayBye();

//we can now also stech the usage of methods akka functions in c++ as we know

int ans= SampleClass.addition(5,10);
Console.WriteLine(ans);

int ans2 = SampleClass.tri_addition(ans, 20);
Console.WriteLine(ans2);
double[] vlu = new double[5] { 1, 2, 5, 3, 4 };

mathTask.AllAddition(vlu);
