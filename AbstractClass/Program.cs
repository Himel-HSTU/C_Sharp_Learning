// Today we will learn about abstract classes in C#. An abstract class is a class that cannot be instantiated on its own and is meant to be inherited by other classes. It can contain abstract methods (methods without implementation) as well as concrete methods (methods with implementation).
// Abstract classes can also have abstract methods(Just Declaration,No Body) which must be implemented by derived classes.
// We cannot create an instance of an abstract class, but we can create instances of derived classes that inherit from the abstract class.
// Abstract classes are useful when you want to provide a common base class for a group
// of related classes, while still allowing for specific implementations in the derived classes.
// In real world scenarios, abstract classes are often used to define a common interface for a set of related classes, while allowing each class to provide its own implementation of that interface.




//Book book = new Book(); // this means that we are creating an instance of the Book class, which is derived from the InventoryItem class. We can access the properties of the InventoryItem class through the Book class instance.
//book.ProductName = "C# Programming";

// InventoryItem item = new InventoryItem(); //early this is kind of meaningless,after making Abstract it will not even possible to create an instance of the InventoryItem class because it is an abstract class. We can only create instances of the derived classes like Book or Vehicle.
// This is possible to make but it is not a good practice to create an instance of the InventoryItem class
// because it is meant to be a base class for other classes. It is better to create instances of the derived classes like Book or Vehicle

Toyota mycar = new Toyota();
Console.WriteLine(mycar.Model);

Console.WriteLine(mycar.YearManufactured);




Console.ReadLine();

public abstract class Vehicle // creating instance of Vehicle class is kind of meaningless it doesn't specify any specific type of vehicle, it is just a general class that can be used to represent any type of vehicle
{                    // Thus we can make it abstract class to prevent it from being instantiated directly and to indicate that it is meant to be a base class for other classes that represent specific types of vehicles.  
    public string VINNumber { get; set; }

    public string Manufacturer { get; set; }
    // Property declare here will be implemented in the derived class using the constructor of the derived class. This is because the Model property is already defined in the abstract class Vehicle, so we don't need to define it again in the derived class Toyota. We can just set the value of the Model property in the constructor of the Toyota class.
    public string Model { get; set; } 

    public int YearManufactured { get; set; }

    public abstract void Start(); // Method declare under abstract class must be implemented in the derived class, otherwise it will give compile time error. This is because abstract methods are meant to be overridden in derived classes, and they do not have any implementation in the base class. If a derived class does not provide an implementation for an abstract method, it will also be considered an abstract class and cannot be instantiated.

}

public class Car : Vehicle // Now we deep dive a little bit, as car is a sort of vehicle
{
   
    public int NumberOfDoors { get; set; }  = 4;
    public bool HasSunroof { get; set; } = true;

    public override void Start()
    {
        Console.WriteLine("We dont have any clear idea about the start method for a generic car.");
    }
}

public class Toyota : Car // Now we deep dive a little bit, as Toyota is a sort of car
{
    // public string Model { get; set; } = "Camry"; this is already defined in the abstract class Vehicle, so we don't need to define it again in the derived class Toyota. We can just set the value of the Model property in the constructor of the Toyota class.
    public Toyota()
    { // used constructor to set the value of the Model property in the derived class Toyota. This is because the Model property is already defined in the abstract class Vehicle, so we don't need to define it again in the derived class Toyota. We can just set the value of the Model property in the constructor of the Toyota class.
        Model = "Camry";
        YearManufactured = 2020;
    }
    public string Color { get; set; } = "Silver";
    public int YearManufactured { get; set; } = 2022;
    public override void Start()
    {
        Console.WriteLine("Car starts with a key turn.");
    }
}

public class EV : Car
{
    public override void Start()
    {
        Console.WriteLine("Car starts with a button press.");
    }
}