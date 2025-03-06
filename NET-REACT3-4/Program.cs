using System;

// Interface örneği
public interface IVehicle
{
    void Start();
    void Stop();
}


public class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Car is stopping...");
    }
}


public class Bicycle : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bicycle is starting...");
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle is stopping...");
    }
}

class Program
{
    static void Main()
    {
        
        IVehicle car = new Car();
        car.Start();  
        car.Stop();   

        Console.WriteLine();

        IVehicle bicycle = new Bicycle();
        bicycle.Start();  
        bicycle.Stop();   
    }
}
