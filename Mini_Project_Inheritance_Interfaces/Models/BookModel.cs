
public class BookModel : InventoryItemModel,IPurchasable {
    public int NumberOfPages { get; set; }

    public void Purchase()
    {
        QuantityInStock--;
        Console.WriteLine();
        Console.WriteLine($"One of Our {ProductName} just got Purchased");
    }
}
