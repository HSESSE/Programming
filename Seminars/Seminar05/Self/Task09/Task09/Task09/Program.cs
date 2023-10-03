namespace Task09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double S = Math.Sqrt(x * x + y * y);
            bool g = S <= 2 && x >= 0 && x >= y;
            Console.WriteLine(g);
        }
    }
}