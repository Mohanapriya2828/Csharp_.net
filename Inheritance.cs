using System;
class vehicle
{
    public string brand;
    public void start()
    {
        Console.WriteLine(brand + " started");
    }
}
class car : vehicle
{
    public int seatingcapacity;
    public void showcapacity()
    {
        Console.WriteLine(brand + " car seats " + seatingcapacity + " people");
    }
}
class bike : vehicle
{
    public bool hasgear;
    public void kickstart()
    {
        Console.WriteLine(brand + " bike kickstarted");
    }
}

class program
{
    public static void Main(string[] args)
    {
        car c = new car();
        c.brand = "toyota";
        c.seatingcapacity = 5;
        c.start();
        c.showcapacity();
        bike b = new bike();
        b.brand = "yamaha";
        b.hasgear = true;
        b.start();
        b.kickstart();
    }
}
