namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());

            if (1 <= n && n < 11)
                if (l > 0)
                {
                    Console.WriteLine("{0:f2}", (n * l * l) / (4 * Math.Tan(Math.PI / n)));
                }

        }
    }
}