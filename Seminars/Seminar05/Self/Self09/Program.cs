// Ваше решение.
using System;
class Program
{
    public static void Main()
    {
        double.TryParse(Console.ReadLine(), out double x);
        double.TryParse(Console.ReadLine(), out double y);
        
        if (((x * x + y * y <= 4) && (y <= 0.5 * x) && (y >= 0)) || ((x * x + y * y <= 4) && (y <= 0) && (x >= 0)))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}