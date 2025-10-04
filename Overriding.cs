using System;
class vehicle
{
    public virtual void start()
    {
        Console.WriteLine("vehicle started");
    }
}
class car : vehicle
{
    public sealed override void start()
    {
        Console.WriteLine("car started");
    }
}
class sportsCar : car
{
    // cannot override start here because it is sealed 
}

class program
{
    public static void Main(string[] args)
    {
        vehicle v = new vehicle();
        v.start();
        car c = new car();
        c.start();
        vehicle vc = new car();
        vc.start();
    }
}
