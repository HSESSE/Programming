internal class Program
{
    public static void Main()
    {
        string? a = Console.ReadLine();
        char b = a[0];
        int c = Convert.ToInt32(b);

        int F = c switch
        {
            >= 48 and <= 57 => 100,
            >= 65 and <= 90 => 200,
            >= 97 and <= 122 => 300,
            _ => 400
        };
        
        Console.WriteLine(F);
        Console.ReadKey();

        Console.ReadKey();
    }
}