using System;
using System.Collections.Generic;
class product : IComparable<product>
{
    public string name { get; set; }
    public double price { get; set; }
    public int CompareTo(product other)
    {
        return price.CompareTo(other.price);
    }
}
class program
{
    public static void Main()
    {
        List<product> products = new List<product>
        {
            new product { name = "item1", price = 50.5 },
            new product { name = "item2", price = 25.0 },
            new product { name = "item3", price = 75.3 }
        };
        products.Sort();
        foreach (var p in products)
        {
            Console.WriteLine(p.name + " - " + p.price);
        }
    }
}
