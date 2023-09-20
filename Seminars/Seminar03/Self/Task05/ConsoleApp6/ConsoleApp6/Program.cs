namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double D;
            double x1;
            double x2;
            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            double c = double.Parse(Console.ReadLine());

            D = b * b - 4 * a * c;

            if (a != 0 && b != 0 && D > 0)
            {
                x1 = ((-b) + Math.Sqrt(D)) / 2 * a;

                x2 = ((-b) - Math.Sqrt(D)) / 2 * a;

                Console.WriteLine((a + "*x^2 +(" + b + ")*x +(" + c + ") = 0") + ", x1 = " + x1 + ", x2 = " + x2);
            }
            else if (a == 0)
            {
                x1 = -c / b;

                Console.WriteLine((b + "*x +(" + c + ") = 0") + ", x1 = " + x1);

            }
            else if (b == 0)
            {
                x1 = -c / a;

                Console.WriteLine((a + "*x^2 +(" + c + ") = 0") + ", x1 = sqrt( " + x1 + ")");

            }
            else if (D < 0)
            {
                Console.WriteLine("Нет действительных корней");
            }
        }
    }
}