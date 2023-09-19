// Your code here!
using System;
class Program
{
    static void Main()
    {
        float u = Convert.ToInt32(Console.ReadLine());
        float r = Convert.ToInt32(Console.ReadLine());
        float i = u / r;
        float p = (u * u) / r;
        Console.WriteLine("I = {0}", i);
        Console.WriteLine("P = {0}", p);
    }
}