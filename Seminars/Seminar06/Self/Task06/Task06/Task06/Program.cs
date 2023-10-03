namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 5; n <= 12; n++)
            {
                int S = 0;
                int cur = 1;
                for (int k = 1; k <= n; k++)
                {
                    cur *= k;
                    S += cur;
                }
                Console.WriteLine($"При n = {n} S(n) = {S}");
            }
        }
    }
}