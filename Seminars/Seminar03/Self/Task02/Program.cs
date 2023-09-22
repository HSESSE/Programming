internal class Program
{
    public static void Main()
    {
        Console.Write("Введите x: ");
        float x = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите y: ");
        float y = Convert.ToSingle(Console.ReadLine());

        double length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));


        if (y < 0)
        {
            Console.WriteLine("Точка не принадлежит области");
            Console.ReadKey();
            return;
        }
        if (length > 2)
        {
            Console.WriteLine("Точка не принадлежит области");
        }
        else if (length == 2 || length == 1)
        {
            Console.WriteLine("Точка лежит на границе");
        }
        else if (length < 2 && length > 1)
        {
            Console.WriteLine("Точка лежит внутри области");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит области");
        }

        Console.ReadKey();
    }
}