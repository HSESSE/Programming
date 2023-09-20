namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());

            double y = double.Parse(Console.ReadLine());

            double s = Math.Sqrt(x * x + y * y);

            string helper1 = s < R ? "Точка внутри круга!" : "Точка вне круга!";

            Console.WriteLine(helper1);
        }
    }
}