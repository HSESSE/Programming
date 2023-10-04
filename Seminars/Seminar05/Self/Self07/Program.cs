// Ваше решение.
using System;
class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int n);
        string str_n = Convert.ToString(n);
        int i = str_n.Length - 1;
        bool f = false;
        string new_s = "";
        while (i >= 0)
        {
            if (str_n[i] == '0' && f == false)
            {
                i -= 1;
                continue;
            }
            else
            {
                f = true;
                new_s += str_n[i];
            }
            i -= 1;
        }
        Console.WriteLine($"{n} -> {new_s}");
    }
}