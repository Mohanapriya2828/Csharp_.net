using System;
using System.Data;
using System.Data.SqlClient;
class Program
{
    static string connStr = "Data Source=.;Initial Catalog=EmployeeDB;Integrated Security=True";
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. create");
            Console.WriteLine("2. read");
            Console.WriteLine("3. update");
            Console.WriteLine("4. delete");
            Console.WriteLine("5. exit");
            Console.Write("Enter choice (1-5): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    createEmployee();
                    break;
                case "2":
                    readEmployees();
                    break;
                case "3":
                    updateEmployee();
                    break;
                case "4":
                    deleteEmployee();
                    break;
                case "5":
                    Console.WriteLine("Exiting");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
    static void createEmployee()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter dept: ");
        string dept = Console.ReadLine();
        using (SqlConnection con = new SqlConnection(connStr))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert INTO Employees(Name, Age, Dept) VALUES(@name, @age, @dept)", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@dept", dept);
            cmd.ExecuteNonQuery();
        }

        Console.WriteLine("Employee inserted successfully.");
    }
    static void readEmployees()
    {
        using (SqlConnection con = new SqlConnection(connStr))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * FROM Employees", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("\nEmployees Table:");
            while (reader.Read())
            {
                Console.WriteLine($"id: {reader["Id"]}, name: {reader["Name"]}, age: {reader["Age"]}, dept: {reader["Dept"]}");
            }
            reader.Close();
        }
    }
    static void updateEmployee()
    {
        Console.Write("Enter name of employee to update: ");
        string name = Console.ReadLine();
        Console.Write("Enter new age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter new dept: ");
        string dept = Console.ReadLine();
        using (SqlConnection con = new SqlConnection(connStr))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Employees SET Age=@age, Dept=@dept WHERE Name=@name", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@dept", dept);
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Employee updated." : "No employee found.");
        }
    }
    static void deleteEmployee()
    {
        Console.Write("Enter name of employee to delete: ");
        string name = Console.ReadLine();
        using (SqlConnection con = new SqlConnection(connStr))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete FROM Employees WHERE Name=@name", con);
            cmd.Parameters.AddWithValue("@name", name);
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Employee deleted." : "No employee found.");
        }
    }
}

