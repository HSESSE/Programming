using System.Data;
using System;
class Program
{
    public static void Main()
    {
        double.TryParse(Console.ReadLine(), out double a);
        double.TryParse(Console.ReadLine(), out double b);
        double.TryParse(Console.ReadLine(), out double c);

        Console.WriteLine($"{a}x^2 + {b}x + {c}");

        if (a == 0)
        {
            double x1 = -c / b;
            Console.WriteLine($"x = {x1}");
        }
        else
        {
            if (b == 0)
            {
                double x2 = Math.Sqrt(-c / a);
                Console.WriteLine($"x1 = {x2}");
                Console.WriteLine($"x2 = -{x2}");
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("Нет действительных корней");
                }
                else
                {
                    if (d == 0)
                    {
                        double x3 = -b / (2 * a);
                        Console.WriteLine($"x = {x3}");
                    }
                    else
                    {
                        double x4 = (-b + Math.Sqrt(d)) / (2 * a);
                        double x5 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine($"x1 = {x4}");
                        Console.WriteLine($"x2 = {x5}");
                    }
                }
            }
        }
    }
}