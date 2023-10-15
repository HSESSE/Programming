using System;
class Program
{
    public static void Main()
    {
        Console.Write("Введите код операции: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (b != 0 && x <= 4 && x >= 1)
        {
            switch (x)
            {
                case 1:
                double s = a + b;
                Console.WriteLine($"{a} + {b} = {s}");
                break;

                case 2:
                double q = a - b;
                Console.WriteLine($"{a} - {b} = {q}");
                break;

                case 3:
                double p = a * b;
                Console.WriteLine($"{a} * {b} = {p}");
                break;

                case 4:
                double l = a / b;
                Console.WriteLine($"{a} / {b} = {l}");
                break;
            }
        }
        else {Console.WriteLine("Error!");}
    }
}
