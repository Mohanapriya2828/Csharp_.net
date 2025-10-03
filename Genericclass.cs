using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Repo<int> intrepo = new Repo<int>();
        intrepo.Add(10);
        intrepo.Add(20);
        intrepo.Update(0, 15);
        intrepo.Delete(1);
        Console.WriteLine("All integers:");
        foreach (var i in intrepo.Getall())
        {
            Console.WriteLine(i);
        }
        Repo<string> stringrepo = new Repo<string>();
        stringrepo.Add("Hello");
        stringrepo.Add("World");
        stringrepo.Update(1, "C#");
        stringrepo.Delete(0);
        Console.WriteLine("All strings:");
        foreach (var s in stringrepo.Getall())
        {
            Console.WriteLine(s);
        }
    }
}
public class Repo<T>
{
    private List<T> items = new List<T>();
    public void Add(T item)
    {
        items.Add(item);
    }
    public void Update(int index, T item)
    {
        if (index >= 0 && index < items.Count)
            items[index] = item;
    }
    public void Delete(int index)
    {
        if (index >= 0 && index < items.Count)
            items.RemoveAt(index);
    }
    public List<T> Getall()
    {
        return new List<T>(items);
    }
}
