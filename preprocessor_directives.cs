#define symbol
using System;
class example
{
    public static void Main()
    {
#if symbol
        Console.WriteLine("symbol is defined");
#else
        Console.WriteLine("Symbol is not defined");
#endif
#region Warning and Error
#warning This is a compiler warning
#endregion
    }
}