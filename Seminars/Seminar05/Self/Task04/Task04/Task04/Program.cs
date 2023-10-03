namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f = 0.0;
            double current;


            for (int n = 1;n <= 1000 ; n++)
            {
                current = 1.0 / n * (n+1) * (n + 2);             
                f += current;
            }

            Console.WriteLine(f);
            
        }
    }
}