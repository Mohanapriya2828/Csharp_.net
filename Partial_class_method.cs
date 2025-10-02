using System;
public partial class Student
{
    private string name;

    public Student(string name)
    {
        this.name = name;
        showdetails();
    }

    partial void showdetails();
}
public partial class Student
{
    partial void showdetails()
    {
        Console.WriteLine("Student Name: " + name);
    }
}
class Program
{
    public static void Main()
    {
        Student s1 = new Student("priya");
        Student s2 = new Student("sabi");
    }
}
