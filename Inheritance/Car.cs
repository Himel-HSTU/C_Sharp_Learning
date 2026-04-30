// Car.cs
// Car.cs
public class Car
{
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }

    public void StartCar()
    {
        Console.WriteLine("Car has started.");
    }

    public void StopCar()
    {
        Console.WriteLine("Car has stopped.");
    }
}