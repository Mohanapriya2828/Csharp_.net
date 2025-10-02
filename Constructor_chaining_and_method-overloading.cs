using System;
class Student
{
	private string name;
	private int age;
	public string Name
	{
		get { return name; }
		set { name = string.IsNullOrEmpty(value) ? "Unknown" : value; }
	}
	public int Age
	{
		get { return age; }
		set { age = (value > 0) ? value : 18; }
	}
	public Student(string name, int age)
	{
		this.name = name;
		this.age = age;
		Console.WriteLine("Full constructor called");
	}
	public Student(string name) : this(name, 18) 
    {
		Console.WriteLine("Constructor with id & name called");
	}
	public Student() : this("NoName", 18)    
    {
		Console.WriteLine("Default constructor called");
	}
	public void Displayinfo()
	{
		Console.WriteLine(" Name: {Name}, Age: {Age}");
	}
	public void Study()     
    {
		Console.WriteLine($"{Name} is studying.");
	}
	public void Study(string subject)  
    {
		Console.WriteLine($"{Name} is studying {subject}.");
	}
}
class Program
{
	public static void Main()
	{
		Student s1 = new Student();
		s1.Displayinfo();
		s1.Study();
		Student s2 = new Student("Alice");
		s2.Displayinfo();
		s2.Study("Math");
	}
}

