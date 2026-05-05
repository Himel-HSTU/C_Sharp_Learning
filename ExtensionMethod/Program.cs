// Today we will learn about extension methods in C#. Extension methods allows you to add new methods to existing types without modifying the original type or creating a new derived type.
// This is particularly useful when you want to add functionality to classes,methods that you do not have control over, such as classes from the .NET Framework or third-party libraries.


HotelRoomModel room = new HotelRoomModel();
room.TurnOnAC().SetTemperature(22).CloseWindows(); // Chaining extension methods

room.TurnOffAC().OpenWindows();

"      himelrahman  ".ToUpper().Trim().Replace("H", "J").PrintToConsole();// trim removing the spaces

"Hello World".PrintToConsole(); // Calling the extension method on a string instance

Console.ReadLine();

public class HotelRoomModel {
    public int Temperature { get; set; }
    public bool IsAcOn { get; set; }

    public bool AreWindowOpen { get; set; } 
}
public static class ExtensionSamples
{
    public static void PrintToConsole(this string message) // this keyword indicates that this is an extension method for the string type
    {
        Console.WriteLine(message);
    }

    public static HotelRoomModel TurnOnAC(this HotelRoomModel room) 
    {
        room.IsAcOn = true;
        return room;
    }
    public static HotelRoomModel TurnOffAC(this HotelRoomModel room) 
    {
        room.IsAcOn = false;
        return room;
    }
    public static HotelRoomModel SetTemperature (this HotelRoomModel room, int temperature) 
    {
        room.Temperature = temperature;
        return room;
    }
    public static HotelRoomModel OpenWindows(this HotelRoomModel room) 
    {
        room.AreWindowOpen = true;
        return room;
    }
    public static HotelRoomModel CloseWindows(this HotelRoomModel room) 
    {
        room.AreWindowOpen = false;
        return room;
    }
}




// ╔══════════════════════════════════════════════════════════════╗
// ║                    EXTENSION METHODS                        ║
// ╚══════════════════════════════════════════════════════════════╝

// WHAT IS IT?
// Adds new methods to existing types WITHOUT modifying the original class.
// Useful when you don't own the class (string, int, List, third-party libs)

// THE 3 RULES — ALL MUST BE FOLLOWED:
// 1. Must be inside a STATIC CLASS
// 2. Must be a STATIC METHOD
// 3. Must have 'this' keyword before the first parameter

// SYNTAX:
// public static class MyExtensions
// {
//     public static ReturnType MethodName(this TypeToExtend paramName)
//     {
//         // logic here
//     }
// }

// EXAMPLE — Extending string (built-in type you don't own):
// public static void PrintToConsole(this string message)
//     → called as: "Hello".PrintToConsole();
//     → 'this string' means: extend the string type

// EXAMPLE — Extending your own class:
// public static HotelRoomModel TurnOnAC(this HotelRoomModel room)
//     → called as: room.TurnOnAC();

// METHOD CHAINING:
// Return 'this' (the object itself) to allow chaining
// room.TurnOnAC().SetTemperature(22).CloseWindows();
// Each method returns room → next method receives it → chain continues
// You've seen this on string already:
// "hello".ToUpper().Trim().Replace("H","J")

// TRIM() — QUICK NOTE:
// Removes whitespace from START and END of a string
// "  himel  ".Trim() → "himel"
// Real use: cleaning user input before processing
// string email = Console.ReadLine().Trim();

// WHEN TO USE ✅
// - Adding utility to types you don't own (string, int, List)
// - Third-party library classes you can't modify
// - Building fluent/chainable APIs
// - Helper methods that logically belong to a type

// WHEN NOT TO USE ❌
// - You own the class → just add the method directly
// - Need access to private fields → extension can't reach them
// - Makes code harder to understand → keep it simple

// REAL WORLD EXAMPLE (ASP.NET — input validation):
// "himel@gmail.com".IsValidEmail()  → true
// "himel das".ToTitleCase()         → "Himel Das"
// "Long text...".Truncate(20)       → "Long text......"

// HOW IT LOOKS VS REALITY:
// "hello".IsValidEmail()
//          ↑ looks like it belongs to string
//            actually lives in your StringExtensions static class
//            C# just makes it look like a real string method