using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Any input:");
        string userInput = Console.ReadLine();
        Console.WriteLine(userInput);

        Console.WriteLine("Double input:");
        string str = Console.ReadLine();
        double r = double.Parse(str);
        Console.WriteLine(r.ToString());
        Console.WriteLine("Good luck with your studies!");
    }
}