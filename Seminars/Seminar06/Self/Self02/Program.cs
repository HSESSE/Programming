using System;
class Program
{
    public static void Main()
    {
        bool a = false;
        bool b = false;
        bool c = false;
        Console.WriteLine("a\tb\tc\tF");
        do
        {
            do
            {
                do
                {
                    bool F = !(a || b && c) || a;
                    Console.WriteLine($"{a}\t{b}\t{c}\t{F}");
                    c = !c;
                } while (c);
                b = !b;
            } while (b);
            a = !a;
        } while (a);
    }
}