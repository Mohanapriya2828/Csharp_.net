using System;
class A
{
    public void show()
    {
        Console.WriteLine("Display Class A ");
    }
}
class B : A
{
    public new void show()
    {
        Console.WriteLine("Display Class B");
    }
}
class Program
{
    static void Main()
    {
        A obj1 = new A();
        obj1.show();
        B obj2 = new B();
        obj2.show();
        A obj3 = new B();
        obj3.show();
    }
}
