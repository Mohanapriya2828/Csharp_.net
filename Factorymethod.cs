using System;
interface Icar
{
    void drive();
}
class Sedan : Icar
{
    public void drive() { Console.WriteLine("Driving sedan"); }
}
class Suv : Icar
{
    public void drive() { Console.WriteLine("Driving suv"); }
}
abstract class CarFactory
{
    public abstract Icar createCar();
}
class SedanFactory : CarFactory
{
    public override Icar createCar() { return new Sedan(); }
}
class SuvFactory : CarFactory
{
    public override Icar createCar() { return new Suv(); }
}
class Program
{
    static void Main()
    {
        CarFactory factory = new SedanFactory();
        Icar car = factory.createCar();
        car.drive();  
        factory = new SuvFactory();
        car = factory.createCar();
        car.drive();  
    }
}
