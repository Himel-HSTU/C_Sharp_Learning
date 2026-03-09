// Today, We are going to explore C# Instantiated Classes, a powerful feature that allows us to create classes
// that are instantiated at runtime. This can be particularly useful when we want to create objects based on
// user input or when we need to work with types that are not known at compile time.
// In this example, we will define a simple instantiated class and demonstrate how to use it in our program.
// #It is more like the Class and Object we learn in Cpp, but with more flexibility and dynamic capabilities.
// In short, The class is like a car that has engine, wheels, and other components. 
// The object is like a specific car that will be created based on the class blueprint.
// Means it will also have engine, wheels, and other components, but it can be customized based on the user's needs.

using InstantiatedClass;

//ModelClass car1 = new ModelClass(); // Object creation using the ModelClass blueprint
//car1.companyName = "Toyota"; // manipulating the object properties
//car1.modelName = "Axia";
//car1.releseYear = "2020";

//ModelClass car2 = new ModelClass();
//car2.companyName = "Honda"; 
//car2.modelName = "Civic";
//car2.releseYear = "2021";

//Console.WriteLine($"Car 1: {car1.companyName} {car1.modelName} {car1.releseYear}");
//Console.WriteLine($"Car 2: {car2.companyName} {car2.modelName} {car2.releseYear}");

// Lets Jump another level.. Cosider the Class BluePrint like Int or Double or String 
// these are also like a blueprint... thus we can use List<ModalClass> to create a list of ModelClass objects, which is more dynamic and flexible than creating individual objects for each car.

List<ModelClass> cars = new List<ModelClass>();
for (int i = 0; i < 3; i++)
{
    ModelClass tempcar = new ModelClass();
    Console.WriteLine($"Enter details for Car {i + 1}:");
    Console.Write("Company Name: ");
    tempcar.companyName = Console.ReadLine();
    Console.Write("Model Name: ");
    tempcar.modelName = Console.ReadLine();
    Console.Write("Relese Year: ");
    tempcar.releseYear = Console.ReadLine();
    cars.Add(tempcar); // Adding the temporary car object which has the model class blueprint and properties to the list
}
foreach (ModelClass mc in cars) {
    Console.WriteLine($"{mc.companyName} {mc.modelName} {mc.releseYear}");
}