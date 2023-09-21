internal class program
{
    public static void Main()
    {
        Console.Write("Введите количество углов: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите длину стороны: ");
        float l = Convert.ToSingle(Console.ReadLine());

        Console.Write($"Площадь фигуры равна: {(n * Math.Pow(l, 2)) / (4 * Math.Tan(Math.PI / n))}");

        Console.ReadKey();
    }
}