using System;
using System.Collections.Generic;
class entity
{
    public int id { get; set; }
    public string name { get; set; }
}
interface irepository<T>
{
    void add(T item);
    void remove(T item);
    IEnumerable<T> getall();
}
class repository<T> : irepository<T>
{
    private List<T> items = new List<T>();
    public void add(T item)
    {
        items.Add(item);
    }
    public void remove(T item)
    {
        items.Remove(item);
    }
    public IEnumerable<T> getall()
    {
        return items;
    }
}
class unitofwork
{
    public repository<entity> entities { get; private set; }
    public unitofwork()
    {
        entities = new repository<entity>();
    }
    public void commit()
    {
        Console.WriteLine("changes committed to database");
    }
}
class program
{
    public static void Main()
    {
        unitofwork uow = new unitofwork();
        entity e1 = new entity { id = 1, name = "item1" };
        entity e2 = new entity { id = 2, name = "item2" };
        uow.entities.add(e1);
        uow.entities.add(e2);
        foreach (var e in uow.entities.getall())
        {
            Console.WriteLine(e.id + " - " + e.name);
        }
        uow.commit();
    }
}
