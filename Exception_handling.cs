using System;
class customexception : Exception
{
    public customexception(string message) : base(message) { }
}
class program
{
    static void validate(int age)
    {
        if (age < 18)
            throw new customexception("age must be 18 or older");
        else
            Console.WriteLine("age is valid");
    }
    public static void Main()
    {
        try
        {
            validate(15);
        }
        catch (customexception ex)
        {
            Console.WriteLine("exception caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("execution completed");
        }
    }
}
