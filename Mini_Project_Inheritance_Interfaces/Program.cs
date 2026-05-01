// Today We will do a Mini Project on Inheritance and Interfaces in C#.
// Following Tim Corey C# Masterclass, Video no - 93



////////////////////////////////

//List<InventoryItemModel> inventory = new List<InventoryItemModel>();
List<IRentable> rentable = new List<IRentable>();
List<IPurchasable> purchasable = new List<IPurchasable>();

var vehicle = new VehicleModel{ProductName = "Toyota", DealerFee = 500, QuantityInStock = 10};
var book = new BookModel{ProductName = "C# Programming", NumberOfPages = 350, QuantityInStock = 5};
var excavator = new ExcavatorModel{ProductName = "CAT 320", QuantityInStock = 3};

rentable.Add(vehicle);
rentable.Add(excavator);

purchasable.Add(vehicle); // changes made here will also reflect in the rentable list because both are pointing to the same objec in memory.
purchasable.Add(book);

bool chk = true;
while (chk)
{
    Console.Write("What Do You Want to Do? Rent or Purchase? Type r for rent and p for purchase: ");
    char userInput = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (userInput == 'r')
    {
        foreach (var item in rentable)
        {
            Console.WriteLine();
            Console.WriteLine($"Item : {item.ProductName} | Quantity In Stock: {item.QuantityInStock}");
            Console.Write("Do You Want to Rent this item? (y/n): ");
            char rentInput = Console.ReadKey().KeyChar;
            if (rentInput == 'y')
            {
                item.Rent();
            }
            // else { }
            Console.WriteLine();
            Console.Write("Are You Here For Returning this item? (y/n): ");
            char returnInput = Console.ReadKey().KeyChar;
            if (returnInput == 'y')
            {
                item.ReturnRental();
            }
            // else { }
            Console.WriteLine();

        }
    }
    else
    {
        foreach (var item in purchasable)
        {
            Console.WriteLine();
            Console.WriteLine($"Item : {item.ProductName} | Quantity In Stock: {item.QuantityInStock}");
            Console.Write("Do You Want to Purchase this item? (y/n): ");
            char purchaseInput = Console.ReadKey().KeyChar;
            if (purchaseInput == 'y')
            {
                item.Purchase();
            }
            Console.WriteLine();
            // else { }
        }
    }
    Console.Clear();
    Console.Write("Are You a New User? (y/n): ");
    char newUserInput = Console.ReadKey().KeyChar;
    if (newUserInput == 'y')
    {
        chk = true;
    }
    else chk = false;
    Console.WriteLine();
}
//inventory.Add(new VehicleModel { ProductName = "Toyota", DealerFee = 500 , QuantityInStock = 10 });
// inventory[0].ProductName = "Toyota Camry"; In this way we can change the ProductName of the first item in the inventory list.
//inventory.Add(new BookModel { ProductName = "C# Programming", NumberOfPages = 350 });

Console.ReadLine();
