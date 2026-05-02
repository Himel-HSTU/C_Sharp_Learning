//Today we will learn about access modifiers in C#. Access modifiers are keywords used to specify the accessibility of types and type members.
//They define how the members of a class or struct can be accessed from other code.
// In short we can say that access modifiers are used to control the visibility and accessibility of classes, methods, properties, and other members in C#.
// When we use public,private ,protected,internal and protected internal access modifiers in C#, we can control the accessibility of our code and ensure that it is used in a safe and secure manner.

using DemoLibrary;

Person person = new Person();
person.FirstName = "John";

Console.WriteLine(person.Getoutput());

Console.ReadLine();

/*
// ==============================
// 🔐 ACCESS MODIFIERS IN C#
// ==============================


// 🔓 public
// Accessible from anywhere:
// - Same class ✅
// - Same project (assembly) ✅
// - Different project (assembly) ✅
// No restrictions at all
public int myPublicVar;


// 🔒 private
// Accessible ONLY inside the same class
// - Same class ✅
// - Outside class ❌
// - Derived class ❌
// Default for class members if nothing is specified
private int myPrivateVar;


// 🏠 internal
// Accessible only within the SAME project (assembly)
// - Same class ✅
// - Same project ✅
// - Different project ❌
internal int myInternalVar;


// 🧬 protected
// Accessible within:
// - Same class ✅
// - Derived class (even in different project) ✅
// - Other classes ❌
protected int myProtectedVar;


// 🧪 protected internal
// Combination of protected + internal
// Accessible within:
// - Same project (any class) ✅
// - Derived class (even in different project) ✅
// - Non-derived class in other project ❌
protected internal int myProtectedInternalVar;


// 🔐 private protected (C# 7.2+)
// Very restrictive combination
// Accessible within:
// - Same class ✅
// - Derived class BUT ONLY inside same project ✅
// - Derived class in different project ❌
// - Other classes ❌
private protected int myPrivateProtectedVar;
 */