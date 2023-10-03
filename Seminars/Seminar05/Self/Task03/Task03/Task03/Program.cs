namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0.0;
            double A;
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                A = double.Parse(Console.ReadLine());
                s += A * Math.Sqrt(A);
            }
            
            Console.WriteLine(s);
        }
    }
}