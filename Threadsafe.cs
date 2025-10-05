using System;
public class logger
{
    private static readonly object lockobj = new object();
    private static logger instance;
    private logger() { }
    public static logger getinstance()
    {
        if (instance == null)
        {
            lock (lockobj)
            {
                if (instance == null)
                {
                    instance = new logger();
                }
            }
        }
        return instance;
    }

    public void log(string message)
    {
        Console.WriteLine(message);
    }
}
class program
{
    public static void Main()
    {
        logger l = logger.getinstance();
        l.log("This is a thread-safe singleton log message.");
    }
}
