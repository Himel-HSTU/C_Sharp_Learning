
public class ExcavatorModel : InventoryItemModel ,IRentable // Available only for rent
{
    public void Dig()
    {
        Console.WriteLine();
        Console.WriteLine("Excavator is digging...");
    }

    public void Rent()
    {
        QuantityInStock--;
        Console.WriteLine();
        Console.WriteLine($"One of our {ProductName} just went on Rent! DUDE :)");
    }

    public void ReturnRental()
    {
        QuantityInStock++;
        Console.WriteLine();
        Console.WriteLine($"We Just Got our {ProductName} from Rental");
    }
}