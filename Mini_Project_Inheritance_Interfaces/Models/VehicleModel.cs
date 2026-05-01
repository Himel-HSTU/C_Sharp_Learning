
public class VehicleModel : InventoryItemModel,IPurchasable,IRentable
{
    public decimal DealerFee { get; set; }

    public void Purchase()
    {
        QuantityInStock--;
        Console.WriteLine();
        Console.WriteLine($"One of Our {ProductName} just got Purchased");
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
