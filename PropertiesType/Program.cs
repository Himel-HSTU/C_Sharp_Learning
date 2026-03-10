// Previous we were using fields in classes, but now we will use properties instead.
//Properties provide a way to control access to the data and can include logic for getting and setting values.
//Its is really important to understand the difference between fields and properties in C#.
//Fields are simple variables that hold data, while properties are more complex and can include logic for
//getting and setting values. Properties can also have different access levels for getting and setting values,
//which allows for better control over the data.For example Restrict the get or set n so on
// Also We Will learn Constructors in this section 
using PropertiesType;

PersonModel person = new PersonModel();
person.FirstName = "John";
person.LastName = "Doe";
person.age = 25;
person.PhoneNumber = "01634665500";
person.NickName = "pcBhai";
Console.WriteLine($"{person.FirstName} {person.LastName} Age: {person.age} Num: {person.PhoneNumber}");
//Output: John Doe Age: 25 Num: *******5500
Console.WriteLine($"{person.FullName}");

PersonModel person2 = new PersonModel("Himel","Rahman","pcBhai",21, "01634665500");
Console.WriteLine($"{person2.FirstName} {person2.LastName} Age: {person2.age} Num: {person2.PhoneNumber}");
