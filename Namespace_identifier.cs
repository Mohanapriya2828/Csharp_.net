using System;
using alias = Mynamespace.aliasnamespace;

class globalnamespace
{
    public void show()
    {
        Console.WriteLine("global class is in global namespace");
    }
}
namespace userdefined
{
    class Student
    {
        public void Show()
        {
            Console.WriteLine("Student class is in userdefined namespace");
        }
    }
}
namespace Mynamespace.aliasnamespace
{
    class Employee
    {
        public void show()
        {
            Console.WriteLine("Alias class is in alias namespace");
        }
    }
}
namespace Nested_namespace
{
    namespace nested
    {
        class Teacher
        {
            public void show()
            {
                Console.WriteLine("Teacher class is in nested namespace");
            }
        }
    }
}


class Program
{
    public static void Main(string[] args)
    {
        userdefined.Student s = new userdefined.Student();
        alias.Employee e = new alias.Employee();
        Nested_namespace.nested.Teacher obj = new Nested_namespace.nested.Teacher();
        global::globalnamespace g = new global::globalnamespace();
        s.Show();
        e.show();
        obj.show();
        g.show();
    }
}
