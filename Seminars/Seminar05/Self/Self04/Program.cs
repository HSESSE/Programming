// Ваше решение.
using System;
class Program
{
    public static void Main()
    {
        double a = 1;
        double b = 2;
        double c = 3;
        double summa = 0;
        double current = 1 / (a * b * c);
        while (current > double.Epsilon)
        {
            summa += current;
            a += 1;
            b += 1;
            c += 1;
            current = 1 / (a * b * c);
        }
        Console.WriteLine(summa);
    }
}