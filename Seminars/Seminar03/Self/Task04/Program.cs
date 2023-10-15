using System;
class Program
{
    public static void Main()
    {
        double.TryParse(Console.ReadLine(), out double x);
        double.TryParse(Console.ReadLine(), out double y);
        Console.WriteLine(x);
        Console.WriteLine(y);

        if (x < y)
        {
            double f1 = Math.Sin(x) + (Math.Cos(y) * Math.Cos(y));
            Console.WriteLine(f1);
        }
        else
        {
            if (x == y)
            {
                double f2 = Math.Log(x);
                Console.WriteLine(f2);
            }
            else
            {
                double f3 = Math.Sin(x * x) + (Math.Cos(y));
                Console.WriteLine(f3);
            }
        }
    }
}