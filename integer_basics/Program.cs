
// ============================================================
//                 INTEGER BASICS
// ============================================================
// Integer data types store whole numbers (no decimals)

int age = 22;                   // Most commonly used (32-bit)
short smallNumber = 120;        // Smaller range (16-bit)
long bigNumber = 9000000000L;   // Very large numbers (64-bit)
byte tiny = 255;                // Only positive 0 to 255

// Use 'int' by default
// Normally int use korbo
// Excess boro hole long use korbo
// short / byte use kori only jodi memory optimization dorkar hoy

Console.WriteLine(age);
Console.WriteLine(smallNumber);
Console.WriteLine(bigNumber);
Console.WriteLine(tiny);



// ============================================================
//                 DOUBLE / FLOAT / DECIMAL BASICS
// ============================================================
// Fractional (decimal) numbers
// By default, C# treats fractional numbers as double
// So we need suffix:
//    'f' → float
//    'm' → decimal

double price = 19.99;           // Most commonly used (64-bit)
float height = 5.9f;            // Smaller range (32-bit)
decimal balance = 10500.75m;    // High precision (128-bit)


// ---------------- Division behavior ----------------

double check = 4 / 2;           // int / int → int result → stored as double (2.0)
double check2 = 4.0 / 2;        // double / int → double result

Console.WriteLine(check.ToString("F2"));   // 2.00
Console.WriteLine(check2.ToString("F5"));  // 2.00000



// ---------------- Precision issues ----------------

float aa = 0.1f;
float bb = 0.2f;

Console.WriteLine(aa + bb);     // Shows 0.3
                                // Actually stored value ≈ 0.30000001
                                // WriteLine rounded output for readability


double a = 0.1;
double b = 0.2;

Console.WriteLine(a + b);       // 0.30000000000000004
                                // Binary floating-point precision issue


decimal c = 0.1m;
decimal d = 0.2m;

Console.WriteLine(c + d);       // 0.3 (exact)

// For regular calculations → double is fine
// For money / financial calculations → ALWAYS use decimal
// float  → fast, low precision
// double → faster, medium precision
// decimal → slow, VERY accurate



// ============================================================
//                 BOOLEAN BASICS
// ============================================================
// Boolean stores true or false

bool isAdult = true;

Console.WriteLine(isAdult);
Console.WriteLine(!isAdult);    // Logical NOT



// ============================================================
//                 CHAR BASICS
// ============================================================
// Char stores a single character

char grade = 'A';
Console.WriteLine(grade);



// ============================================================
//                 STRING BASICS
// ============================================================
// String stores sequence of characters

string name = "John";
Console.WriteLine(name);

string greeting = "Hello, " + name + "!";   // Strings can contain spaces
Console.WriteLine(greeting);

// We already learned more in string_basics/Program.cs



// ============================================================
//                 NULLABLE TYPES
// ============================================================
// Nullable types allow value types to store null
// Useful for user input & database values

// int age = null;   // ❌ Error

int? userAge = null;             // '?' makes it nullable
Console.WriteLine(userAge);      // Blank output

double? userHeight = null;
bool? isMarried = null;

Console.WriteLine(userHeight);   // Blank
Console.WriteLine(isMarried);    // Blank

// Note:
// Nullable types are mostly used with user input & databases
// string is a reference type, so it can be null by default

string? userNickname = null;     // Nullable reference type (modern C#)
Console.WriteLine(userNickname); // Blank



// ============================================================
//                 var KEYWORD
// ============================================================
// Compiler infers the type from assigned value

var city = "New York";           // string
var population = 8419000;        // int
var temperature = 72.5;          // double

Console.WriteLine(city);
Console.WriteLine(population);
Console.WriteLine(temperature);

// Notes:
// - var is still strongly typed
// - Type is decided at compile time
// - Must assign value immediately
// - Overusing var can reduce readability


























/*
//............... Integer Basics ................................
// Integer data types store whole numbers (no decimals)

int age = 22;              // Most commonly used (32-bit)
short smallNumber = 120;   // Smaller range (16-bit)
long bigNumber = 9000000000L; // Very large numbers (64-bit)
byte tiny = 255;         // Only positive 0 to 255

// Use 'int' by default unless you REALLY need others
// normally int use korboo..excess boro hole long use korboo
// otherwise using short and byte jodi memory optimization dorkar hoy
//int chk = 4.00 / 2; // although output is 2.0 (as per hiearchy ) but it will be stored as 2
//Console.WriteLine(chk);
Console.WriteLine(age);
Console.WriteLine(smallNumber);
Console.WriteLine(bigNumber);
Console.WriteLine(tiny);

//................ Double Basics ...............................

// Double data types store fractional numbers (with decimals)
// by default, C# treats any fractional numbers as double
// so we need to suffix 'f' for float and 'm' for decimal

double price = 19.99;        // Most commonly used (64-bit)
float height = 5.9f;        // Smaller range (32-bit)
decimal balance = 10500.75m; // High precision (128-bit)
//................
double check = 4 / 2; //give only integer output as both are integer thn convert and store as double
double check2 = 4.0 / 2; // one is double so output will be double
Console.WriteLine(check.ToString("F2"));//2.00
Console.WriteLine(check2.ToString("F5"));//2.00000



float aa = 0.1f;
float bb = 0.2f;
Console.WriteLine(aa + bb); // output: 0.3 should be 0.30000001  
                            // float er precision e emon kichu problem thakee
                            // but writeline a beautified kore round kore dekhay tai 0.3 dekhay

double a = 0.1;
double b = 0.2;

Console.WriteLine(a + b); // output: 0.30000000000000004 should be 0.3 
// double er precision e emon kichu problem thakte pare
// tai jodi high precision dorkar hoy tahole decimal use korte hobe
decimal c = 0.1m;
decimal d = 0.2m;
Console.WriteLine(c + d); // output: 0.3
                          // for regular calculations double is fine
                          // but for modeny/financial calculations use decimal
                          // float is used when need to save memory and precision is not a big concern
                          //float  → fast, low precision
                          //double → faster, medium precision
                          //decimal → slow, VERY accurate
//.................. Boolean Basics ...............................
// Boolean data types store true or false values
bool isAdult = true;
Console.WriteLine(isAdult);
Console.WriteLine(!isAdult);

//.............. Char Basics ................................
// Char data types store single characters
char grade = 'A';
Console.WriteLine(grade);

//.............. String Basics .............................
// String data types store sequences of characters
string name = "John";
Console.WriteLine(name);
string greeting = "Hello, " + name + "!"; // unlike C,cpp string can be space separated sentences
Console.WriteLine(greeting);
// We already learned more about strings in string_basics/Program.cs

//.............. nullable Types .............................
// Nullable types can store null values in addition to their normal range
// assume we are getting age from user input, but user may not provide it
// we cannot just set age to 0 as 0 is also a valid age
// thus we use nullable types

//int age = null; // This will give error
int? userAge = null; // ? makes it nullable
Console.WriteLine(userAge); // Output: blank
Console.WriteLine("HELLO");
// same can be done for other data types
double? userHeight = null;
bool? isMarried = null;
Console.WriteLine(userHeight); // Output: blank
Console.WriteLine(isMarried); // Output: blank
                              // Note: nullable types are mostly used in databases and user inputs
                              //for string there is no nullable type as string is reference type and can be null by default
string? userNickname = null; // although string is reference type and can be null by default but in modern C# we can use ? to indicate that this string can be null
Console.WriteLine(userNickname); // Output: blank

//............. var Keyword ...............................
// var keyword allows implicit typing, the compiler infers the type based on the assigned value
var city = "New York"; // inferred as string
var population = 8419000; // inferred as int
var temperature = 72.5; // inferred as double
Console.WriteLine(city);                        // Note: var is still strongly typed, once assigned, the type cannot change
Console.WriteLine(population);                 // issue hobe jodi var er value na deoa hoye..then compiler type infer korte parbe na
Console.WriteLine(temperature);               // var can only be used for local variables inside methods
                                            // it can decrease code readability if overused
*/