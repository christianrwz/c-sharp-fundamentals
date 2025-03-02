public class Vehicle
{
    public required string Brand { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }

    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting.");
    }
    public virtual void Stop()
    {
        Console.WriteLine("Vehicle is stopping.");
    }
}