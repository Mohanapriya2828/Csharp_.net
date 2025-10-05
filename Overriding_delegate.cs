using System;
delegate void vehiclehandler();
class vehicle
{
    public virtual void start()
    {
        Console.WriteLine("Vehicle starting");
    }
}
class car : vehicle
{
    public override void start()
    {
        Console.WriteLine("Car starting");
    }
}
class bike : vehicle
{
    public override void start()
    {
        Console.WriteLine("Bike starting");
    }
}
class program
{
    static void Main()
    {
        vehicle mycar = new car();
        vehicle mybike = new bike();
        vehiclehandler handler;
        handler = mycar.start;
        handler();
        handler = mybike.start;
        handler();
    }
}
