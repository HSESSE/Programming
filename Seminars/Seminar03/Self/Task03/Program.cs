using System;
class Program
{
    public static void Main()
    {
        double.TryParse(Console.ReadLine(), out double x);
        double.TryParse(Console.ReadLine(), out double y);

        string a = "Точка внутри области";
        string b = "Точка на границе области";
        string c = "Точка не принадлежит области";

        if (y < 0)
        {
            if (x * x + y * y < 1)
            {
                Console.WriteLine(a);
            }
            else
            {
                if (x * x + y * y == 1)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }

            }
        }
        else
        {
            if (x * x + y * y < 4)
            {
                Console.WriteLine(a);
            }
            else
            {
                if (x * x + y * y == 4)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
