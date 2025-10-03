using System;
delegate void AlarmHandler(string time);
class AlarmClock
{
    public event AlarmHandler alarm; 

    public void Ring(string time)
    {
        Console.WriteLine($"Alarm rings at {time}!");
        alarm?.Invoke(time); 
    }
}
class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
    public void wakeup(string time)
    {
        Console.WriteLine($"{Name} wakes up at {time}");
    }
}
class Program
{
    public static void Main()
    {
        AlarmClock a = new AlarmClock();
        Person p= new Person("priya");
        Person s = new Person("sabi");
        a.alarm += p.wakeup;
        a.alarm += s.wakeup;
        a.Ring("7:00 AM");
    }
}
