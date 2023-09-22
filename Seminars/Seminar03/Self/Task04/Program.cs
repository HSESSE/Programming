internal class Program
{
    public static void Main()
    {
        Console.Write("Введите x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x < y)
        {
            double F = Math.Sin(x) + Math.Pow(Math.Cos(y), 2);
            Console.WriteLine($"x, y, F: {x}, {y}, {F}");
        }
        else if (x == y)
        {
            double F = Math.Log(Math.Abs(x));
            Console.WriteLine($"x, y, F: {x}, {y}, {F}");

        }
        else if (x > y)
        {
            double F = Math.Sin(Math.Pow(x, 2)) + Math.Cos(y);
            Console.WriteLine($"x, y, F: {x}, {y}, {F}");

        }

        Console.ReadLine();

    }
}