using System;
using System.Threading;
class logger
{
    private static logger instance;
    private static readonly object lockobj = new object();
    private logger() { }
    public static logger getinstance()
    {
        if (instance == null)
        {
            lock (lockobj)
            {
                if (instance == null)
                    instance = new logger();
            }
        }
        return instance;
    }
    public void log(string message)
    {
        Console.WriteLine($"{message} - {GetHashCode()}");
    }
}
class program
{
    public static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            new Thread(() => logger.getinstance().log("thread log")).Start();
        }

        Thread.Sleep(1000);
    }
}
