using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Dec\tHex");
        Console.WriteLine("=================");
        for (int i = 0; i < 16; i++)
        {
            Console.WriteLine("{0}\t{0:X4}", i);
        }
    }
}