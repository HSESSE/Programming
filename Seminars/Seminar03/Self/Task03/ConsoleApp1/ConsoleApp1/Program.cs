namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());

            double Y = double.Parse(Console.ReadLine());

            double S = Math.Sqrt(X * X + Y * Y);

            double R1 = 2;

            double R2 = 1;

            if ((Y > 0 && S > R1) || (Y < 0 && S > R2))
            {
                Console.WriteLine("Точка вне области");
            }
            else if ((Y > 0 && S < R1) || (Y < 0 && S < R2) || (Y == 0 && X < 1 && X > (-1)))
            {
                Console.WriteLine("Точка внутри области");
            }
            else if ((Y > 0 && S == R1) || (Y < 0 && S == R2) || (Y == 0 && (X >= 1 && X <= 2) || (X <= (-1) && X >= (-2))))
            {
                Console.WriteLine("Точка на границе области");
            }
        }
    }
}