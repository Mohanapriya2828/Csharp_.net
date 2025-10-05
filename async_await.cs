using System;
using System.Threading.Tasks;
class program
{
    public static async Task<string> fetchdata()
    {
        await Task.Delay(2000);
        return "data fetched successfully";
    }
    public static async Task Main()
    {
        Console.WriteLine("fetching data");
        string result = await fetchdata();
        Console.WriteLine(result);
    }
}
