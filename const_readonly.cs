using System;
class const_readonly
{
    public const int val = 100;          
    public readonly int a;          
    public const_readonly(int value)
    {
        a = value;
    }
}
class Program
{
    static void Main()
    {
        const_readonly e1 = new const_readonly(10);
        const_readonly e2 = new const_readonly(20);
        Console.WriteLine($"ConstValue: {const_readonly.val}");
        Console.WriteLine($"e1.ReadOnlyValue: {e1.a}");
        Console.WriteLine($"e2.ReadOnlyValue: {e2.a}");
    }
}
