using System;
using System.Collections;
using System.Collections.Generic;
class studentcollection : IEnumerable<string>
{
    private List<string> names = new List<string> { "priya", "sabi", "renu","jayabal" };

    public IEnumerator<string> GetEnumerator()
    {
        foreach (var n in names)
        {
            yield return n;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
class program
{
    static void Main()
    {
        studentcollection s = new studentcollection();
        foreach (var n in s)
        {
            Console.WriteLine(n);
        }
    }
}
