using System;
abstract class shape
{
    public abstract double calculatearea();
}
class circle : shape
{
    public double radius;
    public circle(double r)
    {
        radius = r;
    }
    public override double calculatearea()
    {
        return Math.PI * radius * radius;
    }
}
class rectangle : shape
{
    public double length;
    public double width;
    public rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    public override double calculatearea()
    {
        return length * width;
    }
}
class program
{
    public static void Main(string[] args)
    {
        shape c = new circle(5);
        Console.WriteLine("circle area: " + c.calculatearea());
        shape r = new rectangle(4, 6);
        Console.WriteLine("rectangle area: " + r.calculatearea());
    }
}
