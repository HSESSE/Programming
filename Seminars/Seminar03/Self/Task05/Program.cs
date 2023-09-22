internal class Program
{
    public static void Main()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите c: ");
        double c = Convert.ToSingle(Console.ReadLine());

        string s_a = a < 0 ? $"{a}" : $"+{a}";
        string s_b = b < 0 ? $"{b}" : $"+{b}";
        string s_c = c < 0 ? $"{c}" : $"+{c}";

        Console.WriteLine($"{s_a}x^2{s_b}x{s_c}");

        if (a == 0)
        {
            Console.WriteLine($"Единственный корень, равный {-c / b}");
        }
        else if (b == 0)
        {
            Console.WriteLine($"Два одинаковых корня, равных +-{Math.Sqrt(-c / a)}");
        }
        else if ((Math.Pow(b, 2) - 4 * a * c) < 0)
        {
            Console.WriteLine("Нет действительных корней");
        }
        else if ((Math.Pow(b, 2) - 4 * a * c) == 0)
        {
            Console.WriteLine($"Один корень, равный: {-b / (2 * a)}");
        }
        else if ((Math.Pow(b, 2) - 4 * a * c) > 0)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"Первый корень, равный: {(-b - Math.Sqrt(D))/ (2 * a)}");
            Console.WriteLine($"Второй корень, равный: {(-b - Math.Sqrt(D)) / (2 * a)}");
        }

        Console.ReadKey();
    }
}