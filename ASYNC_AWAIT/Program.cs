class Program5
{
    static async Task Main(string[] args)
    {
        Task<int> number1 = GetNumber(5);
        Task<int> number2 = GetNumber(10);
         
        int[] results = await Task.WhenAll(number1, number2);

        foreach (int i in results)
        {
            Console.WriteLine(i);
        }
      
         
        string name =  await GetName();
         
        Console.WriteLine("Ahoj" + name);
         
         
        int age = await GetAge();
        Console.WriteLine(age);
         
         
         
         
    }
    public static async Task<int> GetNumber(int number)
    {
        await Task.Delay(1000);
        return number * 2;
    }

    public static async Task<string> GetName()
    {
        await Task.Delay(1000);
        return "Michal";
    }
     
    public static  async Task<int> GetAge()
    {
        await Task.Delay(1000);
        return 16;
    }
      
     
     
}