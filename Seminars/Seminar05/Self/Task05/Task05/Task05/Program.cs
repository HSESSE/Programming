namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f = 0;
            double current;
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i < k; i++)
            {
                current = 1.0/i ; f += current; 
            }
            Console.WriteLine(f);
        }
    }
}