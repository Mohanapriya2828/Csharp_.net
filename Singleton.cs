using System;
class singleton
{
    private static singleton instance = null;
    private static readonly object lockobj = new object();
    private singleton() { }
    public static singleton getinstance()
    {
        if (instance == null)
        {
            lock (lockobj)
            {
                if (instance == null)
                {
                    instance = new singleton();
                }
            }
        }
        return instance;
    }
    public void showmessage()
    {
        Console.WriteLine("singleton instance");
    }
}
class program
{
    public static void Main(string[] args)
    {
        singleton s1 = singleton.getinstance();
        singleton s2 = singleton.getinstance();
        s1.showmessage();
        Console.WriteLine(object.ReferenceEquals(s1, s2));
    }
}
