using System;
using System.Threading.Tasks;
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
        Task[] tasks = new Task[5];
        for (int i = 0; i < 5; i++)
        {
            tasks[i] = Task.Run(() => logger.getinstance().log("task log"));
        }
        Task.WaitAll(tasks);
    }
}
