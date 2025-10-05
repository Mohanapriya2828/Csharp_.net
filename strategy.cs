using System;
interface istrategy
{
    void execute();
}
class strategya : istrategy
{
    public void execute()
    {
        Console.WriteLine("Executing strategy A");
    }
}
class strategyb : istrategy
{
    public void execute()
    {
        Console.WriteLine("Executing strategy B");
    }
}
class context
{
    private istrategy strategy;

    public context(istrategy strategy)
    {
        this.strategy = strategy;
    }

    public void setstrategy(istrategy strategy)
    {
        this.strategy = strategy;
    }

    public void doaction()
    {
        strategy.execute();
    }
}
class program
{
    public static void Main()
    {
        context ctx = new context(new strategya());
        ctx.doaction();
        ctx.setstrategy(new strategyb());
        ctx.doaction();
    }
}
