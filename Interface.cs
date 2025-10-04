using System;
interface ishape
{
    double calculatearea();
}
class circle : ishape
{
    public double radius;
    public circle(double r)
    {
        radius = r;
    }
    public double calculatearea()
    {
        return Math.PI * radius * radius;
    }
}
class rectangle : ishape
{
    public double length;
    public double width;
    public rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    public double calculatearea()
    {
        return length * width;
    }
}
class program
{
    public static void Main(string[] args)
    {
        ishape c = new circle(5);
        Console.WriteLine("circle area: " + c.calculatearea());
        ishape r = new rectangle(4, 6);
        Console.WriteLine("rectangle area: " + r.calculatearea());
    }
}
