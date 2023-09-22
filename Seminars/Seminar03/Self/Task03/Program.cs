using System.ComponentModel.Design;

internal class Program
{
    public static void Main()
    {
        Console.Write("Введите x: ");
        float x = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите y: ");
        float y = Convert.ToSingle(Console.ReadLine());

        double length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));


        if ((y < 0) && length > 1)
        {
            Console.WriteLine("Точка не принадлежит области");
        }
        else if ((y < 0) && length < 1)
        {
            Console.WriteLine("Точка лежит внутри области");
        }
        else if ((y < 0) && length == 1)
        {
            Console.WriteLine("Точка лежит на границе");
        }
        else if (length > 2)
        {
            Console.WriteLine("Точка не принадлежит области");
        }
        else if (length == 2)
        {
            Console.WriteLine("Точка лежит на границе");
        }
        else if (length < 2)
        {
            Console.WriteLine("Точка лежит внутри области");
        }

        Console.ReadKey();
    }
}