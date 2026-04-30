// Today we will explore the concept of inheritance in C#. Inheritance is a fundamental principle of object-oriented programming
// that allows a class to inherit properties and methods from another class.
// This promotes code reusability and establishes a hierarchical relationship between classes.

Dog kutta = new Dog();
kutta.Name = "Tommy";
kutta.Eat();
kutta.Bark();
kutta.Bite();
BabyDog babykutta = new BabyDog();
babykutta.Name = "Jr.Tommy";
babykutta.Eat();
babykutta.Bark();
babykutta.crysound  = "Waa! Waa!";
babykutta.Cry();

Cat biral = new Cat();
biral.Name = "Mimi";
biral.Eat();

Cat babyBiral = new BabyCat();
babyBiral.Name = "Jr.Mimi";
babyBiral.Eat();
public class Animal {
    public string Name { get; set; }

    // the virtual keyword allows derived classes to override this method if they want to provide a specific implementation
    // otherwise, the base class implementation will be used
    public virtual void Eat()
    { 
        Console.WriteLine($"{Name} is Eating");
    }
}

public class  Dog : Animal // Dog class inherits from Animal class
{
    public void Bark()
    { // the name is inherited from the Animal class
        Console.WriteLine($"{Name} says: Vauk! Vauk!");
    }
    public void Bite() {
        Console.WriteLine($"{Name} is Biting!!!");
    }
}

public class BabyDog : Dog // BabyDog class inherits from Dog class, which in turn inherits from Animal class
{
    public string crysound { get; set; } 

    public void Cry() {
        Console.WriteLine($"{Name} is Crying: {crysound}");
    }
}

// Now theres a more things to learn like virtual methods, method overriding, and polymorphism,
// which are advanced concepts in inheritance. These concepts allow derived classes to provide specific implementations of methods defined in base classes,
// enabling more flexible and dynamic behavior in object-oriented programming.

public class Cat : Animal 
{
    public override void Eat() // this overrides the Eat method from the Animal class,we can have particular implementation of the Eat method for the Cat class
    {
        Console.WriteLine($"The Cat Named:{Name} is Eating Much More");
    }
}
public class BabyCat : Cat
{
    public override void Eat()
    {
        base.Eat(); // sometimes we want to call the base class implementation of a method in addition to providing our own implementation. This is done using the base keyword.
        Console.WriteLine($"Hence The {Name} BabyCat is Eating Much Less");
    }
}