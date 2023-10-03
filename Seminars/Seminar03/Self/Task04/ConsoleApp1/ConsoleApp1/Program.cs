namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());

            double Y = double.Parse(Console.ReadLine());

            if (X < Y)
            {
                Console.WriteLine("X = " + X + " " + "Y = " + Y + " " + "F = " + (Math.Sin(X) + Math.Cos(Y) * Math.Cos(Y)));
            }

            else if (X == Y)
            {
                Console.WriteLine("X = " + X + " " + "Y = " + Y + " " + "F = " + (Math.Log(Math.Abs(X))));
            }
            else if (X > Y)
            {
                Console.WriteLine("X = " + X + " " + "Y = " + Y + " " + "F = " + (Math.Sin(X) * Math.Sin(X) + Math.Cos(Y)));
            }
        }
    }
}