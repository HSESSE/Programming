namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int y = int.Parse(Console.ReadLine());

            int z = int.Parse(Console.ReadLine());

            int helper1 = z >= x ? (y >= x ? x : y) : (y >= z ? z : y);

            int helper3 = z >= x ? (y >= z ? y : z) : (y >= x ? y : x);

            int helper2 = x + y + z - helper1 - helper3;

            Console.WriteLine(helper1 + " " + helper2 + " " + helper3);

        }
    }
}