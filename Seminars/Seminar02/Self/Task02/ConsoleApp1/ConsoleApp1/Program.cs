namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());

            double ost = x1 % 10 + x2 % 10;

            Console.WriteLine("Сумма целых частей " + x1 + " и " + x2 + " равна " + "{0:f0}", x1 + x2 - 1);

            Console.WriteLine("Сумма дробных частей " + x1 + " и " + x2 + " равна 0," + "{0:f0}", ost - 1);
        }
    }
}