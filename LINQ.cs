using System;
using System.Collections.Generic;
using System.Linq;
class employee
{
    public int id { get; set; }
    public string name { get; set; }
    public string department { get; set; }
    public int salary { get; set; }
}
class program
{
    static void Main()
    {
        List<employee> e = new List<employee>
        {
            new employee { id = 1, name = "priya", department = "hr", salary = 40000 },
            new employee { id = 2, name = "sabi", department = "it", salary = 55000 },
            new employee { id = 3, name = "renu", department = "it", salary = 60000 },
            new employee { id = 4, name = "jay", department = "finance", salary = 50000 }
        };
        var highsalary = e.Where(x => x.salary > 50000);
        var groupdept = e.GroupBy(x => x.department);
        var orderbyname = e.OrderBy(x => x.name);
        var selectnames = e.Select(x => x.name);
        Console.WriteLine("Filtered:");
        foreach (var x in highsalary) Console.WriteLine(x.name);
        Console.WriteLine("Grouped:");
        foreach (var g in groupdept)
        {
            Console.WriteLine(g.Key);
            foreach (var emp in g) Console.WriteLine(emp.name);
        }
        Console.WriteLine("Ordered:");
        foreach (var x in orderbyname) Console.WriteLine(x.name);
        Console.WriteLine("Selected:");
        foreach (var x in selectnames) Console.WriteLine(x);
    }
}
