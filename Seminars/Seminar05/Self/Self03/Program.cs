// Ваше решение.
using System;
class Program
{
    public static void Main()
    {
        double.TryParse(Console.ReadLine(), out double a);
        int.TryParse(Console.ReadLine(), out int n);
        double summa_pr = 0;
        double x = 0;
        double x1 = 0;
        double y1 = 0;
        double plus = a / n;

        while (x < a)
        {
            x1 += plus;
            y1 = x1 * x1;
            summa_pr += (x1 - x) * y1;
            x += plus;
        }

        Console.WriteLine($"Площадь: {summa_pr}");
    }
}