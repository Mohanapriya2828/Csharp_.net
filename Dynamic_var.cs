using System;

class Program
{
    static void Main()
    {
        var a = 10;
        // a = "hello"; 

        dynamic b = 10;
        Console.WriteLine("b as int: " + b);

        b = "hello";  
        Console.WriteLine("b as string: " + b);
        // int result = b + 5; 
    }
}
