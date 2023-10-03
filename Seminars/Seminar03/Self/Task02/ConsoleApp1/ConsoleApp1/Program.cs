namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());

            double Y = double.Parse(Console.ReadLine());

            double S = Math.Sqrt(X * X + Y * Y);

            double R1 = 1;
            double R2 = 2;

            if (S < R1 || S > R2)
            {
                Console.WriteLine("Точка вне области");
            }
            else if (Y < 0 || Y > 2)
            {
                Console.WriteLine("Точка вне области");
            }
            else if (S > R1 && S < R2 && Y > 0)
            {
                Console.WriteLine("Точка внутри области");
            }
            else if (Y >= 0 && (S == R1 || S == R2))
            {
                Console.WriteLine("Точка на границе области");
            }
        }
    }
}