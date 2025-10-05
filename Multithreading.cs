using System;
using System.Threading;
using System.Threading.Tasks;
class program
{
    static void threadmethod()
    {
        Console.WriteLine("thread running: " + Thread.CurrentThread.ManagedThreadId);
    }
    static void taskmethod()
    {
        Console.WriteLine("task running: " + Task.CurrentId);
    }
    public static void Main()
    {
        Thread t1 = new Thread(threadmethod);
        Thread t2 = new Thread(threadmethod);
        t1.Start();
        t2.Start();
        Task task1 = Task.Run(() => taskmethod());
        Task task2 = Task.Run(() => taskmethod());
        t1.Join();
        t2.Join();
        Task.WaitAll(task1, task2);
    }
}
