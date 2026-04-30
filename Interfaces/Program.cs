// Today we will explore the concept of interfaces in C#. An interface defines a contract that classes can implement.
// It specifies a set of methods and properties that implementing classes must provide, without dictating how they should be implemented.
// In simple word a class have to follow the method,properties and events defined in the interface.

//Say you have completely unrelated classes — a Dog, a Robot, and a Human. None of them share a parent. But all of them can swim.
// Thus you can define an interface called ISwimmer that has a method Swim(). Each of these classes have to implement the ISwimmer interface and provide their own implementation of the Swim() method.

Human boy = new Human();
boy.Name = "John";
boy.Swim();
Animal doggy = new Animal();
doggy.Name = "Tommy";
doggy.Swim();
doggy.Bite();

ISwimmer swimmer1 = new Animal();
//swimmer1.Name = "Dolphin"; // we can set the other properties of the Animal class through the ISwimmer interface reference, but we can only access the members defined in the ISwimmer interface.
swimmer1.Swim(); // This will call the Swim method of the Animal class

public interface ISwimmer
{
    void Swim();

}
public interface IBite
{
    void Bite();
}
public class Guest
{
    public string Name { get; set; }
}
public class Human : Guest,ISwimmer
{ // We can use both the inheritance and interface implementation in a single class. First Inherit Class then Interface
    public void Swim() {
        Console.WriteLine($"Myself {Name}, Yes!!! I Know Swimming");
    }
}
public class Animal : Guest,ISwimmer, IBite // We can use multiple interfaces in a single class- One after another with comma separation. This is called multiple interface implementation.
{
    public void Swim() {
        Console.WriteLine($"I'm {Name},Animal!!! I Also Know Swimming");
}
    public void Bite() {
        Console.WriteLine($"I'm {Name},Animal!!! I Can Bite");
    }
}