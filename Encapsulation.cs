using System;
class Account
{
    private double balance;

    public void deposit(double amt)
    {
        if (amt > 0)
        {
            balance += amt;
            Console.WriteLine($"Deposited: {amt}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    public void withdraw(double amt)
    {
        if (amt > 0 && amt <= balance)
        {
            balance -= amt;
            Console.WriteLine($"Withdrawn: {amt}. Remaining balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }
    public double bankbalance
    {
        get
        {
            return balance;
        }
        set 
        { 
            balance = value; 
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Account a= new Account();
        a.deposit(500);    
        a.withdraw(200);   
        Console.WriteLine($"Final balance: {a.bankbalance}");
    }
}