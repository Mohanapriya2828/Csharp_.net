using System;
public class accessdemo
{
    private int p = 1;
    public int q = 2;
    protected int r = 3;
    internal int s = 4;
    protected internal int t = 5;
    private protected int u = 6;

    public void showall()
    {
        Console.WriteLine($"{p},{q},{r},{s},{t},{u}");
    }
}

class derived : accessdemo
{
    public void showderived()
    {
        Console.WriteLine($"{q},{r},{s},{t},{u}");
    }
}

class program
{
    static void Main()
    {
        accessdemo a = new accessdemo();
        Console.WriteLine($"{a.q},{a.s},{a.t}");
        a.showall();

        derived d = new derived();
        d.showderived();
    }
}
