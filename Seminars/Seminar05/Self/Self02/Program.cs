using System;
// Ваше решение.
class Program
{
    static void Main(string[] args)
    {
        int count_int = 0;
        int count_double = 0;
        int count_oth = 0;

        string s = Console.ReadLine();
        do
        {
            int.TryParse(s, out int a);
            double.TryParse(s, out double b);
            if (a != 0  || s == "0")
            {
                count_int += 1;
            }
            else if (b != 0)
            {
                count_double += 1;
            }
            else
            {
                count_oth += 1;
            }
            s = Console.ReadLine();
        } while (s != "0");
        Console.WriteLine($"Количество int: {count_int}");
        Console.WriteLine($"Количество double: {count_double}");
        Console.WriteLine($"Количество нечисловых: {count_oth}");
    }
}