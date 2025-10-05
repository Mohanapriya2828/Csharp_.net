using System;
delegate int Operation(int a, int b);
class Program
{
    static int Add(int x, int y) => x + y;
    static int Subtract(int x, int y) => x - y;
    static int Multiply(int x, int y) => x * y;
    static int Divide(int x, int y) => x / y;
    static void Main()
    {
        Operation op;
        op = Add;
        Console.WriteLine("Addition: " + op(10, 5));
        op = Subtract;
        Console.WriteLine("Subtraction: " + op(10, 5));
        op = Multiply;
        Console.WriteLine("Multiplication: " + op(10, 5));
        op = Divide;
        Console.WriteLine("Division: " + op(10, 5));
    }
}
