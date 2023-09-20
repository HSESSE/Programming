namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out double a);
            Console.WriteLine();

            Console.Write("Введите b: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out double b);
            Console.WriteLine();

            Console.Write("Введите c: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out double c);
            Console.WriteLine();

            char chB = b < 0 ? '-' : '+';
            char chC = c < 0 ? '-' : '+';

            Console.WriteLine($"Получим уравнение вида: {a}x**2 {chB} {Math.Abs(b)}x {chC} {Math.Abs(c)} = 0");

            
            double x1, x2;
            if (a == 0 && b != 0)
            {
                Console.WriteLine($"Вырожденный случай, 1 корень x1 = {-c / b}");
            }
            else if (b == 0 && c <= 0)
            {
                Console.WriteLine($"Два совпадающих корня x1 = x2 = {Math.Sqrt(-c / a)}");
            }
            else
            {
                double D = (b * b) - (4 * a * c);
                if (D < 0)
                {
                    Console.WriteLine("Нет действительных корней");
                }
                else if (D >= 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);

                    Console.WriteLine($"x1 = {x1}\t x2 = {x2}");
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так");
                }
                
            }
            
        }
    }
}