// Ваше решение.
using System;
class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int k);
        int k1 = 1;
        double summa = 0;
        while (k1 <= k)
        {
            summa += 1.0 / k1;
            k1 += 1;
        }
        string s = string.Format("{0:F4}", summa);
        Console.WriteLine(s);
        
    }
}