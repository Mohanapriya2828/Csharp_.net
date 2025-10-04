using System;
public class calc
{
	public int add(int a, int b)
	{
		return a + b;
	}

	public double add(double a, double b)
	{
		return a + b;
	}

	public int add(int a, int b, int c)
	{
		return a + b + c;
	}
}
public class shape
{
	public virtual void draw()
	{
		Console.WriteLine("drawing shape");
	}
}
public class circle : shape
{
	public override void draw()
	{
		Console.WriteLine("drawing circle");
	}
}
public class rectangle : shape
{
	public override void draw()
	{
		Console.WriteLine("drawing rectangle");
	}
}
class program
{
	static void Main()
	{
		calc c = new calc();
		Console.WriteLine(c.add(2, 3));
		Console.WriteLine(c.add(2.5, 3.5));
		Console.WriteLine(c.add(1, 2, 3));

		shape s1 = new circle();
		shape s2 = new rectangle();
		s1.draw();
		s2.draw();
	}
}
