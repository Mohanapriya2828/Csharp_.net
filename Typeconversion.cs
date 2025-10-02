using System;
class Animal
{
    public void speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    public static void Main()
    {
        int a = 10;
        double b = a; 
        Console.WriteLine("Implicit conversion: " + b);

        double c = 89.99;
        int val = (int)c;
        Console.WriteLine("Explicit conversion: " + val);
        object obj = "abc";
        string str = (string)obj;
        string str1 = obj as string;
        Console.WriteLine("Explicit conversion: " + str1);

        //Animal a1=new Animal();
        //string str2 = a1 as string;
        Animal animal = new Dog();
        if (animal is Dog)                 
            Console.WriteLine("animal is a Dog");
        Dog d= animal as Dog;
        if (d != null)
            Console.WriteLine("a is converted as dog");
        else
            Console.WriteLine("a cannot be converted as Dog");


        string num = "123";
        int n = Convert.ToInt32(num);
        Console.WriteLine("Convert class conversion: " + n);

        double pi = 3.14;
        int i = Convert.ToInt32(pi);
        Console.WriteLine("Convert double to int: " + i);
    }
}
