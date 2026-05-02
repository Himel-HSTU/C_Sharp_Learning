// Today we will learn about abstract classes in C#. An abstract class is a class that cannot be instantiated on its own and is meant to be inherited by other classes. It can contain abstract methods (methods without implementation) as well as concrete methods (methods with implementation).
// Abstract classes can also have abstract methods(Just Declaration,No Body) which must be implemented by derived classes.
// We cannot create an instance of an abstract class, but we can create instances of derived classes that inherit from the abstract class.
// Abstract classes are useful when you want to provide a common base class for a group
// of related classes, while still allowing for specific implementations in the derived classes.
// In real world scenarios, abstract classes are often used to define a common interface for a set of related classes, while allowing each class to provide its own implementation of that interface.




//Book book = new Book(); // this means that we are creating an instance of the Book class, which is derived from the InventoryItem class. We can access the properties of the InventoryItem class through the Book class instance.
//book.ProductName = "C# Programming";

// InventoryItem item = new InventoryItem(); //early this is kind of meaningless,after making Abstract it will not possible to create an instance of the InventoryItem class because it is an abstract class. We can only create instances of the derived classes like Book or Vehicle.
// This is possible to make but it is not a good practice to create an instance of the InventoryItem class
// because it is meant to be a base class for other classes. It is better to create instances of the derived classes like Book or Vehicle








Console.ReadLine();

public abstract class InventoryItem
{ // Instead of this being a normal class, we can make it an abstract class by adding the abstract keyword before the class keyword.
  // This will prevent us from creating instances of the InventoryItem class directly, and will force us to create instances of the derived classes like Book or Vehicle.
    public string ProductName { get; set; }
    public int QuantityOnHand { get; set; } 
}
public class Book : InventoryItem
{
    
}

public class Vehicle : InventoryItem
{

}