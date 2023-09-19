using System;
class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double.TryParse(Console.ReadLine(), out double l);

        if (1 <= n && n < 11 && n != 2 && l > 0 && Math.Tan(Math.PI / n) > 0)
        {
            double s = ((n * l) * (n * l)) / (4 * Math.Tan(Math.PI / n));
            Console.WriteLine(s);
        }
    }
}